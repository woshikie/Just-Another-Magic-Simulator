
using System.Collections;

namespace Card
{
	public class LostLegacy : Card
	{
		/*
		Name a nonartifact, nonland card. Search target player's graveyard, hand, and library for any number of cards with that name and exile them. That player shuffles his or her library, then draws a card for each card exiled from hand this way.
		*/
		private const string UniqueCardName = "Lost Legacy";
		public LostLegacy() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] {  };
			Colors = new string[] {  };
			SubTypes = new string[] {  };
			SuperTypes = new string[] {  };
		}

	}
}
