
using System.Collections;

namespace Card
{
    public class SelectforInspection : Card
    {
        /*
        Return target tapped creature to its owner's hand. Scry 1. (Look at the top card of your library. You may put that card on the bottom of your library.)
        */
        private const string UniqueCardName = "Select for Inspection";
        public SelectforInspection() : base(UniqueCardName) { }

    }
}
