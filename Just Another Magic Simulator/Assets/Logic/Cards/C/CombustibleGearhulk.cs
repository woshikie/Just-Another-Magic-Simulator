
using System.Collections;

namespace Card
{
    public class CombustibleGearhulk : Card
    {
        /*
        First strike
When Combustible Gearhulk enters the battlefield, target opponent may have you draw three cards. If the player doesn't, put the top three cards of your library into your graveyard, then Combustible Gearhulk deals damage to that player equal to the total converted mana cost of those cards.
        */
        private const string UniqueCardName = "Combustible Gearhulk";
        public CombustibleGearhulk() : base(UniqueCardName) { }

    }
}
