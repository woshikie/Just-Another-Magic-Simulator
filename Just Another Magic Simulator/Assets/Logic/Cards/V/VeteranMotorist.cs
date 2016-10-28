
using System.Collections;

namespace Card
{
    public class VeteranMotorist : Card
    {
        /*
        When Veteran Motorist enters the battlefield, scry 2.
Whenever Veteran Motorist crews a Vehicle, that Vehicle gets +1/+1 until end of turn.
        */
        private const string UniqueCardName = "Veteran Motorist";
        public VeteranMotorist() : base(UniqueCardName) { }

    }
}
