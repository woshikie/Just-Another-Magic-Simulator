
using System.Collections;

namespace Card
{
    public class FleetwheelCruiser : Card
    {
        /*
        Trample, haste
When Fleetwheel Cruiser enters the battlefield, it becomes an artifact creature until end of turn.
Crew 2 (Tap any number of creatures you control with total power 2 or more: This Vehicle becomes an artifact creature until end of turn.)
        */
        private const string UniqueCardName = "Fleetwheel Cruiser";
        public FleetwheelCruiser() : base(UniqueCardName) { }

    }
}
