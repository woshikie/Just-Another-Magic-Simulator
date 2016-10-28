
using System.Collections;

namespace Card
{
    public class Malfunction : Card
    {
        /*
        Enchant artifact or creature
When Malfunction enters the battlefield, tap enchanted permanent.
Enchanted permanent doesn't untap during its controller's untap step.
        */
        private const string UniqueCardName = "Malfunction";
        public Malfunction() : base(UniqueCardName) { }

    }
}
