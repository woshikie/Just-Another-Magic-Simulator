
using System.Collections;

namespace Card
{
    public class AetherfluxReservoir : Card
    {
        /*
        Whenever you cast a spell, you gain 1 life for each spell you've cast this turn.
Pay 50 life: Aetherflux Reservoir deals 50 damage to target creature or player.
        */
        private const string UniqueCardName = "Aetherflux Reservoir";
        public AetherfluxReservoir() : base(UniqueCardName) { }

    }
}
