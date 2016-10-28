
using System.Collections;

namespace Card
{
    public class GlassblowersPuzzleknot : Card
    {
        /*
        When Glassblower's Puzzleknot enters the battlefield, scry 2, then you get {E}{E}. (You get two energy counters. To scry 2, look at the top two cards of your library, then put any number of them on the bottom of your library and the rest on top in any order.)
{2}{U}, Sacrifice Glassblower's Puzzleknot: Scry 2, then you get {E}{E}.
        */
        private const string UniqueCardName = "Glassblower's Puzzleknot";
        public GlassblowersPuzzleknot() : base(UniqueCardName) { }

    }
}
