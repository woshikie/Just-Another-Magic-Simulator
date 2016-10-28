
using System.Collections;

namespace Card
{
    public class GontiLordofLuxury : Card
    {
        /*
        Deathtouch
When Gonti, Lord of Luxury enters the battlefield, look at the top four cards of target opponent's library, exile one of them face down, then put the rest on the bottom of that library in a random order. For as long as that card remains exiled, you may look at it, you may cast it, and you may spend mana as though it were mana of any type to cast it.
        */
        private const string UniqueCardName = "Gonti, Lord of Luxury";
        public GontiLordofLuxury() : base(UniqueCardName) { }

    }
}
