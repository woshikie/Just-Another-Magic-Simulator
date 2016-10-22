
using System.Collections;

namespace Card
{
    public class FailedInspection : Card
    {
        /*
        Counter target spell. Draw a card, then discard a card.
        */
        private const string UniqueCardName = "Failed Inspection";
        public FailedInspection() : base(UniqueCardName) { }

    }
}
