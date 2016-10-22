
using System.Collections;

namespace Card
{
    public class BotanicalSanctum : Card
    {
        /*
        Botanical Sanctum enters the battlefield tapped unless you control two or fewer other lands.
{T}: Add {G} or {U} to your mana pool.
        */
        private const string UniqueCardName = "Botanical Sanctum";
        public BotanicalSanctum() : base(UniqueCardName) { }

    }
}
