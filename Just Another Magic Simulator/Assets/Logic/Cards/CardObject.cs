using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CardObject : MonoBehaviour {
    [SerializeField]
    Image Front, Back;
    [SerializeField]
    string CardName = "No-Name";
    Card.Card myCard;
    
    public void SetCard(Card.Card newCard){
        myCard = newCard;
        StartCoroutine(
            Card.CardCrawler.CrawlerTask(myCard, delegate {
                    Front.sprite = myCard.CardImage;
                    CardName = myCard.CardName;
                }
            ));
    }

	// Use this for initialization
	void Start () {
        //Card.CardCrawler.Crawler(card);
	}
	
	// Update is called once per frame
	void Update () {
        /*
        if (card != null){
            Front.sprite = card.CardImage;
            card.OnUpkeep();
        }
        */
	}
}
