
using System.Collections;

namespace Card
{
    public class DisappearingAct : Card
    {
        /*
        As an additional cost to cast Disappearing Act, return a permanent you control to its owner's hand.
Counter target spell.
        */
        private const string UniqueCardName = "Disappearing Act";
        public DisappearingAct() : base(UniqueCardName) { }

    }
}
