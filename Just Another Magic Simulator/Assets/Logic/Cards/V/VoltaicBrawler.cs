
using System.Collections;

namespace Card
{
    public class VoltaicBrawler : Card
    {
        /*
        When Voltaic Brawler enters the battlefield, you get {E}{E} (two energy counters).
Whenever Voltaic Brawler attacks, you may pay {E}. If you do, it gets +1/+1 and gains trample until end of turn.
        */
        private const string UniqueCardName = "Voltaic Brawler";
        public VoltaicBrawler() : base(UniqueCardName) { }

    }
}
