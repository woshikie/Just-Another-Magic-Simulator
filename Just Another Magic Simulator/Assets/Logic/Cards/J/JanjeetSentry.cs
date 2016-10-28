
using System.Collections;

namespace Card
{
    public class JanjeetSentry : Card
    {
        /*
        When Janjeet Sentry enters the battlefield, you get {E}{E} (two energy counters).
{T}, Pay {E}{E}: You may tap or untap target artifact or creature.
        */
        private const string UniqueCardName = "Janjeet Sentry";
        public JanjeetSentry() : base(UniqueCardName) { }

    }
}
