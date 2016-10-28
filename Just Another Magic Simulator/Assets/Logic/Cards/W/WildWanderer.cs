
using System.Collections;

namespace Card
{
    public class WildWanderer : Card
    {
        /*
        When Wild Wanderer enters the battlefield, you may search your library for a basic land card, put it onto the battlefield tapped, then shuffle your library.
        */
        private const string UniqueCardName = "Wild Wanderer";
        public WildWanderer() : base(UniqueCardName) { }

    }
}
