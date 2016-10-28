
using System.Collections;

namespace Card
{
    public class TakeDown : Card
    {
        /*
        Choose one —
• Take Down deals 4 damage to target creature with flying.
• Take Down deals 1 damage to each creature with flying.
        */
        private const string UniqueCardName = "Take Down";
        public TakeDown() : base(UniqueCardName) { }

    }
}
