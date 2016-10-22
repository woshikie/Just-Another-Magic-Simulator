
using System.Collections;

namespace Card
{
    public class DemolitionStomper : Card
    {
        /*
        Demolition Stomper can't be blocked by creatures with power 2 or less.
Crew 5 (Tap any number of creatures you control with total power 5 or more: This Vehicle becomes an artifact creature until end of turn.)
        */
        private const string UniqueCardName = "Demolition Stomper";
        public DemolitionStomper() : base(UniqueCardName) { }

    }
}
