
using System.Collections;

namespace Card
{
    public class KeytotheCity : Card
    {
        /*
        {T}, Discard a card: Up to one target creature can't be blocked this turn.
Whenever Key to the City becomes untapped, you may pay {2}. If you do, draw a card.
        */
        private const string UniqueCardName = "Key to the City";
        public KeytotheCity() : base(UniqueCardName) { }

    }
}
