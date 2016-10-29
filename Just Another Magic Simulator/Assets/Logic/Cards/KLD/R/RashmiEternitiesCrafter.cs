
using System.Collections;

namespace Card
{
	public class RashmiEternitiesCrafter : Card
	{
		/*
		Whenever you cast your first spell each turn, reveal the top card of your library. If it's a nonland card with converted mana cost less than that spell's, you may cast it without paying its mana cost. If you don't cast the revealed card, put it into your hand.
		*/
		private const string UniqueCardName = "Rashmi, Eternities Crafter";
		public RashmiEternitiesCrafter() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] {  };
			Colors = new string[] { "green", "green" };
			SubTypes = new string[] { "elf", "elf" };
			SuperTypes = new string[] {  };
		}

	}
}
