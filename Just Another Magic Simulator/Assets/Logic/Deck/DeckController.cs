using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Deck
{
    public class DeckController : MonoBehaviour
    {
        [SerializeField]
        List<string> mainboard = new List<string>();
        [SerializeField]
        List<string> sideboard = new List<string>();
        [SerializeField]
        GameObject CardPrefeb, Parent;
        //For testing
        [SerializeField]
        const string PastebinCode = "cx1381gj";
        [SerializeField]
        Deck myDeck = new Deck();
        // Use this for initialization
        void Start()
        {
            //Get Deck list from API
            StartCoroutine(DeckGetter.PasteBinCrawlerTask(PastebinCode, myDeck, delegate
            {
                //spawn!
                for (int i = 0; i < myDeck.MainBoard.Count; i++){
                    GameObject GO = Instantiate(CardPrefeb);
                    GO.GetComponent<CardObject>().SetCard(myDeck.MainBoard[i]);
                    GO.transform.SetParent(Parent.transform);
                    GO.transform.position = new Vector3(i * 20, 100);
                }
            }
            ));

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}