
using System.Collections;

namespace Card
{
    public class HazardousConditions : Card
    {
        /*
        Creatures with no counters on them get -2/-2 until end of turn.
        */
        private const string UniqueCardName = "Hazardous Conditions";
        public HazardousConditions() : base(UniqueCardName) { }

    }
}
