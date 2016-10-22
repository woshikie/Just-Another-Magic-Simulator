
using System.Collections;

namespace Card
{
    public class DecoctionModule : Card
    {
        /*
        Whenever a creature enters the battlefield under your control, you get {E} (an energy counter).
{4}, {T}: Return target creature you control to its owner's hand.
        */
        private const string UniqueCardName = "Decoction Module";
        public DecoctionModule() : base(UniqueCardName) { }

    }
}
