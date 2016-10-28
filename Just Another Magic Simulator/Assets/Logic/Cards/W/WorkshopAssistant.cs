
using System.Collections;

namespace Card
{
    public class WorkshopAssistant : Card
    {
        /*
        When Workshop Assistant dies, return another target artifact card from your graveyard to your hand.
        */
        private const string UniqueCardName = "Workshop Assistant";
        public WorkshopAssistant() : base(UniqueCardName) { }

    }
}
