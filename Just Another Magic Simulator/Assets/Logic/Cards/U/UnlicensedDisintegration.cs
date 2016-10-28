
using System.Collections;

namespace Card
{
    public class UnlicensedDisintegration : Card
    {
        /*
        Destroy target creature. If you control an artifact, Unlicensed Disintegration deals 3 damage to that creature's controller.
        */
        private const string UniqueCardName = "Unlicensed Disintegration";
        public UnlicensedDisintegration() : base(UniqueCardName) { }

    }
}
