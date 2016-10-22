
using System.Collections;

namespace Card
{
    public class BuilttoSmash : Card
    {
        /*
        Target attacking creature gets +3/+3 until end of turn. If it's an artifact creature, it gains trample until end of turn.
        */
        private const string UniqueCardName = "Built to Smash";
        public BuilttoSmash() : base(UniqueCardName) { }

    }
}
