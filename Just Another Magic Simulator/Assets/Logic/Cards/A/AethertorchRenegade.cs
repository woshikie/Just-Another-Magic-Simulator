
using System.Collections;

namespace Card
{
    public class AethertorchRenegade : Card
    {
        /*
        When Aethertorch Renegade enters the battlefield, you get {E}{E}{E}{E} (four energy counters).
{T}, Pay {E}{E}: Aethertorch Renegade deals 1 damage to target creature.
{T}, Pay {E}{E}{E}{E}{E}{E}{E}{E}: Aethertorch Renegade deals 6 damage to target player.
        */
        private const string UniqueCardName = "Aethertorch Renegade";
        public AethertorchRenegade() : base(UniqueCardName) { }

    }
}
