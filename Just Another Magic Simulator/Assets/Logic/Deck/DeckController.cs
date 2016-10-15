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
        //For testing
        [SerializeField]
        const string PastebinCode = "cx1381gj";
        private Deck myDeck = new Deck();
        // Use this for initialization
        void Start()
        {
            //Get Deck list from API
            DeckGetter.PasteBinCrawler(PastebinCode, myDeck);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}