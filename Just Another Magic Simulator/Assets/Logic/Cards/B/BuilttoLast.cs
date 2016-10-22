
using System.Collections;

namespace Card
{
    public class BuilttoLast : Card
    {
        /*
        Target creature gets +2/+2 until end of turn. If it's an artifact creature, it gains indestructible until end of turn. (Damage and effects that say "destroy" don't destroy it.)
        */
        private const string UniqueCardName = "Built to Last";
        public BuilttoLast() : base(UniqueCardName) { }

    }
}
