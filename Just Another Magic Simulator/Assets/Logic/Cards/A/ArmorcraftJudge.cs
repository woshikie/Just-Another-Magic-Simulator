
using System.Collections;

namespace Card
{
    public class ArmorcraftJudge : Card
    {
        /*
        When Armorcraft Judge enters the battlefield, draw a card for each creature you control with a +1/+1 counter on it.
        */
        private const string UniqueCardName = "Armorcraft Judge";
        public ArmorcraftJudge() : base(UniqueCardName) { }

    }
}
