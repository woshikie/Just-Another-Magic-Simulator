
using System.Collections;

namespace Card
{
    public class RushofVitality : Card
    {
        /*
        Target creature gets +1/+0 and gains lifelink and indestructible until end of turn. (Damage dealt by that creature also causes its controller to gain that much life, and it can't be destroyed by damage or effects that say "destroy.")
        */
        private const string UniqueCardName = "Rush of Vitality";
        public RushofVitality() : base(UniqueCardName) { }

    }
}
