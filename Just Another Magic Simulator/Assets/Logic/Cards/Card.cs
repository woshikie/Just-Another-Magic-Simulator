using UnityEngine;
using SimpleJSON;
using System.Threading;
using System.Collections.Generic;
using System.Net;

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
    static class CardCrawler
    {
        readonly static List<Thread>  ListCrawler = new List<Thread>();
        public static void Crawler(Card Output)
        {
            Thread crawler = new Thread(() => CrawlerTask(Output));
            ListCrawler.Add(crawler);
            crawler.Start();
        }
        private static void CrawlerTask(Card Output)
        {
            const string URL_PREFIX = "http://api.deckbrew.com/mtg/cards/"; //using deckbrew API!
            string URL = URL_PREFIX + Output.CardID;
            string data = new WebClient().DownloadString(URL);
            JSONNode node = JSON.Parse(data);
            if (string.IsNullOrEmpty(node["errors"].ToString()))//no error!
            {
                Output.CardDescription = node["text"].ToString();
                var EditionArrays = node["editions"].AsArray;
                JSONNode LatestEdition = EditionArrays[0];
                for (int i = 1; i < EditionArrays.Count; i++){
                    if (LatestEdition["multiverse_id"].AsInt < EditionArrays[i]["multiverse_id"].AsInt){
                        LatestEdition = EditionArrays[i];
                    }
                }
                URL = LatestEdition["image_url"];
                URL = URL.Replace("https", "http");
                byte[] RetrievedData = new WebClient().DownloadData(URL);
                Output.CardImageRaw = RetrievedData;
            }
            return;
        }
        
    }
    public class Card
    {
        private Sprite _CardImage;
        public Sprite CardImage
        {
            get {
                if (_CardImageRaw != null){
                    Texture2D texture = new Texture2D(0, 0);
                    texture.LoadImage(CardImageRaw);
                    _CardImage = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
                }
                return _CardImage;
            }
            internal set { _CardImage = value; }
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
            get { return CardName.ToLower().Replace(' ', '-'); }
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
