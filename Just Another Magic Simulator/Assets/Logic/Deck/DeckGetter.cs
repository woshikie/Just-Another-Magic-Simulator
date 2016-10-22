using System.Net;
using System;
using System.Collections;
using UnityEngine;

namespace Deck
{
    public static class DeckGetter {
        
        public static IEnumerator PasteBinCrawlerTask(string code, Deck output, Action OnDone)
        {
            const string TEXT_SIDEBOARD = "Sideboard:";
            string URL = "http://pastebin.com/raw/" + code;
            WWW www = new WWW(URL);
            yield return www;
            string Data = www.text;
            //Prepare mainboard text;
            string mainboard_text = "";
            if (Data.Contains(TEXT_SIDEBOARD)){
                mainboard_text = Data.Substring(0, Data.IndexOf(TEXT_SIDEBOARD));
                //Get text from next line;
                //Read Sideboard first;
                string sideboard_txt = Data.Substring(Data.IndexOf(TEXT_SIDEBOARD)+TEXT_SIDEBOARD.Length);
                sideboard_txt = sideboard_txt.Substring(sideboard_txt.IndexOf('\n') + 1);
                string[] scardlines = sideboard_txt.Replace("\r\n","|").Split('|');
                foreach (string line in scardlines){
                    //Get count, Read from first character until reach NOT number;
                    int cardcount = 0;
                    foreach (char c in line){
                        int temp;
                        if (int.TryParse(c.ToString(), out temp)) cardcount = cardcount * 10 + int.Parse(c.ToString());
                        else break;   
                    }
                    if (cardcount == 0) continue;
                    //Get card name
                    string cardname = line.Substring(line.IndexOf(' ') + 1);
                    while (cardcount-- != 0) output.Sideboard.Add(new Card.Card(cardname));
                }
            }
            //Read mainboard
            string[] mcardlines = mainboard_text.Replace("\r\n","|").Split('|');
            foreach (string line in mcardlines){
                int cardcount = 0;
                //get card count!
                foreach (char c in line){
                    int temp;
                    if (int.TryParse(c.ToString(), out temp)) cardcount = cardcount * 10 + int.Parse(c.ToString());
                    else break;
                }
                if (cardcount == 0) continue;
                //get card name;
                string cardname = line.Substring(line.IndexOf(' ') + 1);
                while (cardcount-- != 0) output.MainBoard.Add(new Card.Card(cardname));
            }
            OnDone();
            yield return null;
        }
    }
}
