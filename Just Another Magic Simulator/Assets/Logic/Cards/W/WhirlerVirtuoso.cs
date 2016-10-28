
using System.Collections;

namespace Card
{
    public class WhirlerVirtuoso : Card
    {
        /*
        When Whirler Virtuoso enters the battlefield, you get {E}{E}{E} (three energy counters).
Pay {E}{E}{E}: Create a 1/1 colorless Thopter artifact creature token with flying.
        */
        private const string UniqueCardName = "Whirler Virtuoso";
        public WhirlerVirtuoso() : base(UniqueCardName) { }

    }
}
