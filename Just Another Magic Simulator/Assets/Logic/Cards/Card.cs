using UnityEngine;
using SimpleJSON;
using System.Threading;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Linq;
using System;
using System.Collections;

namespace Card
{
    static class DefaultCardImage
    {
        const string IMAGE_PATH = "Images/PlaceholderNormal";
        static Sprite CardImage = null;
        public static Sprite Img
        {
            get {
                if (CardImage == null)
                    CardImage = Resources.Load(IMAGE_PATH) as Sprite;
                return CardImage;
            }
        }
    }
    public static class CardCrawler
    {
        public static bool UseBFZLands = true, RandomizeLands = true;
        public class ImageCacheUnit
        {
            private bool _isDone = false;
            public bool isDone
            {
                get { return _isDone; }
                internal set { _isDone = value; }
            }

            private byte[] _data = null;
            public byte[] data
            {
                get { return _data; }
                internal set { _data = value; }
            }
        }
        public static Dictionary<int, ImageCacheUnit> CachedList = new Dictionary<int, ImageCacheUnit>();
        public static IEnumerator CrawlerTask(Card Output, Action OnDone)
        {
            const string URL_PREFIX = "http://api.deckbrew.com/mtg/cards/"; //using deckbrew API!
            string URL = URL_PREFIX + Output.CardID;
            //Debug.Log(URL);
            WWW www = new WWW(URL);
            yield return www;
            string data = www.text;
            JSONNode node = JSON.Parse(data);
            if (string.IsNullOrEmpty(node["errors"].ToString()))//no error!
            {
                //Save data
                Output.CardData = node;
                Output.CardDescription = node["text"];
                
                JSONArray EditionArrays = node["editions"].AsArray;
                JSONNode LatestEdition = EditionArrays[0];
                for (int i = 1; i < EditionArrays.Count; i++)
                {
                    if (LatestEdition["multiverse_id"].AsInt < EditionArrays[i]["multiverse_id"].AsInt)
                    {
                        LatestEdition = EditionArrays[i];
                    }
                }
                int Card_ID = LatestEdition["multiverse_id"].AsInt;
                //Check if image is Already in the list
                if (CachedList.ContainsKey(Card_ID)){
                    while (!CachedList[Card_ID].isDone) yield return new WaitForEndOfFrame();
                    Output.CardImageRaw = CachedList[Card_ID].data;
                }
                else{
                    ImageCacheUnit unit = new ImageCacheUnit();

                    CachedList.Add(Card_ID, unit);
                    URL = LatestEdition["image_url"];
                    URL = URL.Replace("https", "http");
                    www = new WWW(URL);
                    yield return www;
                    byte[] RetrievedData = www.bytes;
                    Output.CardImageRaw = RetrievedData;

                    unit.data = RetrievedData;
                    unit.isDone = true;
                }
                OnDone();
            }
            yield return null;
        }
        
    }
    public class Card
    {
        public enum SuperType
        {
            basic,
            legendary,
            ongoing,
            snow,
            world
        }
        public enum Rarity
        {
            basic,
            common,
            uncommon,
            rare,
            mythic,
            special,
            other
        }
        private Rarity _CardRarity = Rarity.other;
        public Rarity CardRarity{
            get { return _CardRarity; }
            internal set { _CardRarity = value; }
        }
        public static string CardNameToID(string Card) {
            return (new string(Card.Where(c => !char.IsPunctuation(c)).ToArray())).Replace(" ","-").ToLower();
        }
        private Sprite _CardImage;
        public Sprite CardImage
        {
            get {
                if (_CardImageRaw != null){
                    Texture2D texture = new Texture2D(0, 0);
                    texture.LoadImage(CardImageRaw);
                    _CardImage = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
                    _CardImageRaw = null;
                }
                return _CardImage;
            }
            internal set { _CardImage = value; }
        }
        private JSONNode _CardData = null;
        public JSONNode CardData{
            get { return _CardData; }
            internal set { _CardData = value; }
        }
        private byte[] _CardImageRaw;
        public byte[] CardImageRaw {
            get { return _CardImageRaw; }
            internal set { _CardImageRaw = value; }
        }
        private string _CardDescription = "";
        public string CardDescription
        {
            get { return _CardDescription; }
            internal set { _CardDescription = value; }
        }
        public readonly string CardName;
        public string CardID
        {
            get { return CardNameToID(CardName); }
        }
        public Card(string CardName)
        {
            this.CardName = CardName;
            //CardCrawler.Crawler(this);
        }

        public virtual void OnUpkeep() { }
        public virtual void OnDraw() { }
        public virtual void OnLandEnter() { }
        public virtual void OnEnterBattlefield() { }
    }
}
