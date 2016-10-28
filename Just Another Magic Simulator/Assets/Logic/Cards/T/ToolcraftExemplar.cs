
using System.Collections;

namespace Card
{
    public class ToolcraftExemplar : Card
    {
        /*
        At the beginning of combat on your turn, if you control an artifact, Toolcraft Exemplar gets +2/+1 until end of turn. If you control three or more artifacts, it also gains first strike until end of turn.
        */
        private const string UniqueCardName = "Toolcraft Exemplar";
        public ToolcraftExemplar() : base(UniqueCardName) { }

    }
}
