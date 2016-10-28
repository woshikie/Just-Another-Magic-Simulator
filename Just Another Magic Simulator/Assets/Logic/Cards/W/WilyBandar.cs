
using System.Collections;

namespace Card
{
    public class WilyBandar : Card
    {
        /*
        {2}{G}: Wily Bandar gains indestructible until end of turn. (Damage and effects that say "destroy" don't destroy it.)
        */
        private const string UniqueCardName = "Wily Bandar";
        public WilyBandar() : base(UniqueCardName) { }

    }
}
