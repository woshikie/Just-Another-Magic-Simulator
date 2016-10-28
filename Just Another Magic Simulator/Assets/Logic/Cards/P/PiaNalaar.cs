
using System.Collections;

namespace Card
{
    public class PiaNalaar : Card
    {
        /*
        When Pia Nalaar enters the battlefield, create a 1/1 colorless Thopter artifact creature token with flying.
{1}{R}: Target artifact creature gets +1/+0 until end of turn.
{1}, Sacrifice an artifact: Target creature can't block this turn.
        */
        private const string UniqueCardName = "Pia Nalaar";
        public PiaNalaar() : base(UniqueCardName) { }

    }
}
