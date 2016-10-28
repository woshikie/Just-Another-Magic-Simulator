
using System.Collections;

namespace Card
{
    public class MarionetteMaster : Card
    {
        /*
        Fabricate 3 (When this creature enters the battlefield, put three +1/+1 counters on it or create three 1/1 colorless Servo artifact creature tokens.)
Whenever an artifact you control is put into a graveyard from the battlefield, target opponent loses life equal to Marionette Master's power.
        */
        private const string UniqueCardName = "Marionette Master";
        public MarionetteMaster() : base(UniqueCardName) { }

    }
}
