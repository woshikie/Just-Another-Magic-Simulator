
using System.Collections;

namespace Card
{
    public class ConsulsShieldguard : Card
    {
        /*
        When Consul's Shieldguard enters the battlefield, you get {E}{E} (two energy counters).
Whenever Consul's Shieldguard attacks, you may pay {E}. If you do, another target attacking creature gains indestructible until end of turn.
        */
        private const string UniqueCardName = "Consul's Shieldguard";
        public ConsulsShieldguard() : base(UniqueCardName) { }

    }
}
