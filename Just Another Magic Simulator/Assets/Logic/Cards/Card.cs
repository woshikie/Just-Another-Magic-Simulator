using UnityEngine;
using SimpleJSON;
using System.Threading;
using System.Collections.Generic;

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
            const string URL_PREFIX = "https://api.deckbrew.com/mtg/cards/"; //using deckbrew API!
            string URL = URL_PREFIX + Output.CardID;
            WWW www = new WWW(URL);
            while (!www.isDone) ;
            JSONNode node = JSON.Parse(www.text);
            if (string.IsNullOrEmpty(node["errors"].ToString()))//no error!
            {
                Output.CardDescription = node["text"].ToString();
                URL = node["image_url"].ToString();
                www = new WWW(URL);
                while (!www.isDone) ;
                Output.CardImage = Sprite.Create(www.texture, new Rect(0, 0, www.texture.width, www.texture.height), Vector2.zero);
            }
            return;
        }
        
    }
    public class Card
    {
        private Sprite _CardImage = DefaultCardImage.Img;
        public Sprite CardImage
        {
            get { return _CardImage; }
            internal set { _CardImage = value; }
        }
        private string _CardDescription = "";
        public string CardDescription
        {
            get { return CardDescription; }
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
        }    
    }
}
