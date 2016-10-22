
using System.Collections;

namespace Card
{
    public class DynavoltTower : Card
    {
        /*
        Whenever you cast an instant or sorcery spell, you get {E}{E} (two energy counters).
{T}, Pay {E}{E}{E}{E}{E}: Dynavolt Tower deals 3 damage to target creature or player.
        */
        private const string UniqueCardName = "Dynavolt Tower";
        public DynavoltTower() : base(UniqueCardName) { }

    }
}
