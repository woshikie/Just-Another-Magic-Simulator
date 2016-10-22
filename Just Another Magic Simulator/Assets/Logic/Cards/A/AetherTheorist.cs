
using System.Collections;

namespace Card
{
    public class AetherTheorist : Card
    {
        /*
        When Aether Theorist enters the battlefield, you get {E}{E}{E} (three energy counters).
{T}, Pay {E}: Scry 1. (Look at the top card of your library. You may put that card on the bottom of your library.)
        */
        private const string UniqueCardName = "Aether Theorist";
        public AetherTheorist() : base(UniqueCardName) { }

    }
}
