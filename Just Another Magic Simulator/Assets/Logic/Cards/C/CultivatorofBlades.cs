
using System.Collections;

namespace Card
{
    public class CultivatorofBlades : Card
    {
        /*
        Fabricate 2 (When this creature enters the battlefield, put two +1/+1 counters on it or create two 1/1 colorless Servo artifact creature tokens.)
Whenever Cultivator of Blades attacks, you may have other attacking creatures get +X/+X until end of turn, where X is Cultivator of Blades's power.
        */
        private const string UniqueCardName = "Cultivator of Blades";
        public CultivatorofBlades() : base(UniqueCardName) { }

    }
}
