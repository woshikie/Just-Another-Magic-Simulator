using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CardObject : MonoBehaviour {
    [SerializeField]
    Image Front, Back;
    Card.Card card;
	// Use this for initialization
	void Start () {
        Card.CardCrawler.Crawler(card);
	}
	
	// Update is called once per frame
	void Update () {
	    if (card != null){
            Front.sprite = card.CardImage;
            card.OnUpkeep();
        }
	}
}
