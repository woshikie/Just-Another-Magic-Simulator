
using System.Collections;

namespace Card
{
    public class SelfAssembler : Card
    {
        /*
        When Self-Assembler enters the battlefield, you may search your library for an Assembly-Worker creature card, reveal it, put it into your hand, then shuffle your library.
        */
        private const string UniqueCardName = "Self-Assembler";
        public SelfAssembler() : base(UniqueCardName) { }

    }
}
