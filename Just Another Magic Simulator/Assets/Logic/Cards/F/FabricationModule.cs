
using System.Collections;

namespace Card
{
    public class FabricationModule : Card
    {
        /*
        Whenever you get one or more {E} (energy counters), put a +1/+1 counter on target creature you control.
{4}, {T}: You get {E}.
        */
        private const string UniqueCardName = "Fabrication Module";
        public FabricationModule() : base(UniqueCardName) { }

    }
}
