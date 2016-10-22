
using System.Collections;

namespace Card
{
    public class DubiousChallenge : Card
    {
        /*
        Look at the top ten cards of your library, exile up to two creature cards from among them, then shuffle your library. Target opponent may choose one of the exiled cards and put it onto the battlefield under his or her control. Put the rest onto the battlefield under your control.
        */
        private const string UniqueCardName = "Dubious Challenge";
        public DubiousChallenge() : base(UniqueCardName) { }

    }
}
