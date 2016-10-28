
using System.Collections;

namespace Card
{
    public class ThrivingTurtle : Card
    {
        /*
        When Thriving Turtle enters the battlefield, you get {E}{E} (two energy counters).
Whenever Thriving Turtle attacks, you may pay {E}{E}. If you do, put a +1/+1 counter on it.
        */
        private const string UniqueCardName = "Thriving Turtle";
        public ThrivingTurtle() : base(UniqueCardName) { }

    }
}
