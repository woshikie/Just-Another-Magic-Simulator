
using System.Collections;

namespace Card
{
    public class RenegadeFreighter : Card
    {
        /*
        Whenever Renegade Freighter attacks, it gets +1/+1 and gains trample until end of turn.
Crew 2 (Tap any number of creatures you control with total power 2 or more: This Vehicle becomes an artifact creature until end of turn.)
        */
        private const string UniqueCardName = "Renegade Freighter";
        public RenegadeFreighter() : base(UniqueCardName) { }

    }
}
