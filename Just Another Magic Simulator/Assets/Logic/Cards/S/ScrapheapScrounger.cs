
using System.Collections;

namespace Card
{
    public class ScrapheapScrounger : Card
    {
        /*
        Scrapheap Scrounger can't block.
{1}{B}, Exile another creature card from your graveyard: Return Scrapheap Scrounger from your graveyard to the battlefield.
        */
        private const string UniqueCardName = "Scrapheap Scrounger";
        public ScrapheapScrounger() : base(UniqueCardName) { }

    }
}
