
using System.Collections;

namespace Card
{
    public class DemonofDarkSchemes : Card
    {
        /*
        Flying
When Demon of Dark Schemes enters the battlefield, all other creatures get -2/-2 until end of turn.
Whenever another creature dies, you get {E} (an energy counter).
{2}{B}, Pay {E}{E}{E}{E}: Put target creature card from a graveyard onto the battlefield under your control tapped.
        */
        private const string UniqueCardName = "Demon of Dark Schemes";
        public DemonofDarkSchemes() : base(UniqueCardName) { }

    }
}
