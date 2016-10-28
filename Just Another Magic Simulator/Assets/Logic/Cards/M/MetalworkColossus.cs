
using System.Collections;

namespace Card
{
    public class MetalworkColossus : Card
    {
        /*
        Metalwork Colossus costs {X} less to cast, where X is the total converted mana cost of noncreature artifacts you control.
Sacrifice two artifacts: Return Metalwork Colossus from your graveyard to your hand.
        */
        private const string UniqueCardName = "Metalwork Colossus";
        public MetalworkColossus() : base(UniqueCardName) { }

    }
}
