
using System.Collections;

namespace Card
{
    public class MaulfistDoorbuster : Card
    {
        /*
        When Maulfist Doorbuster enters the battlefield, you get {E}{E} (two energy counters).
Whenever Maulfist Doorbuster attacks, you may pay {E}. If you do, target creature can't block this turn.
        */
        private const string UniqueCardName = "Maulfist Doorbuster";
        public MaulfistDoorbuster() : base(UniqueCardName) { }

    }
}
