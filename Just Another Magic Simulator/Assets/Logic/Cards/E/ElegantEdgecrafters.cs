
using System.Collections;

namespace Card
{
    public class ElegantEdgecrafters : Card
    {
        /*
        Elegant Edgecrafters can't be blocked by creatures with power 2 or less.
Fabricate 2 (When this creature enters the battlefield, put two +1/+1 counters on it or create two 1/1 colorless Servo artifact creature tokens.)
        */
        private const string UniqueCardName = "Elegant Edgecrafters";
        public ElegantEdgecrafters() : base(UniqueCardName) { }

    }
}
