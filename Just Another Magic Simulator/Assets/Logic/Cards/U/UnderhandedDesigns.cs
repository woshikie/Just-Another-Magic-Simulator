
using System.Collections;

namespace Card
{
    public class UnderhandedDesigns : Card
    {
        /*
        Whenever an artifact enters the battlefield under your control, you may pay {1}. If you do, each opponent loses 1 life and you gain 1 life.
{1}{B}, Sacrifice Underhanded Designs: Destroy target creature. Activate this ability only if you control two or more artifacts.
        */
        private const string UniqueCardName = "Underhanded Designs";
        public UnderhandedDesigns() : base(UniqueCardName) { }

    }
}
