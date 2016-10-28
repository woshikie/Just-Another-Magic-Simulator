
using System.Collections;

namespace Card
{
    public class SpontaneousArtist : Card
    {
        /*
        When Spontaneous Artist enters the battlefield, you get {E} (an energy counter).
Pay {E}: Target creature gains haste until end of turn.
        */
        private const string UniqueCardName = "Spontaneous Artist";
        public SpontaneousArtist() : base(UniqueCardName) { }

    }
}
