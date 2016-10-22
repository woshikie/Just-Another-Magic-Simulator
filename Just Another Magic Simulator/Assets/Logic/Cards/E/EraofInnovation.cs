
using System.Collections;

namespace Card
{
    public class EraofInnovation : Card
    {
        /*
        Whenever an artifact or Artificer enters the battlefield under your control, you may pay {1}. If you do, you get {E}{E} (two energy counters).
Pay {E}{E}{E}{E}{E}{E}, Sacrifice Era of Innovation: Draw three cards.
        */
        private const string UniqueCardName = "Era of Innovation";
        public EraofInnovation() : base(UniqueCardName) { }

    }
}
