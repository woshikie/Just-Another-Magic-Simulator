
using System.Collections;

namespace Card
{
    public class WoodweaversPuzzleknot : Card
    {
        /*
        When Woodweaver's Puzzleknot enters the battlefield, you gain 3 life and get {E}{E}{E} (three energy counters).
{2}{G}, Sacrifice Woodweaver's Puzzleknot: You gain 3 life and get {E}{E}{E}.
        */
        private const string UniqueCardName = "Woodweaver's Puzzleknot";
        public WoodweaversPuzzleknot() : base(UniqueCardName) { }

    }
}
