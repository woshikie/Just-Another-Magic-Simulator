
using System.Collections;

namespace Card
{
	public class LiberatingCombustion : Card
	{
		/*
		Liberating Combustion deals 6 damage to target creature. You may search your library and/or graveyard for a card named Chandra, Pyrogenius, reveal it, and put it into your hand. If you search your library this way, shuffle it.
		*/
		private const string UniqueCardName = "Liberating Combustion";
		public LiberatingCombustion() : base(UniqueCardName) {
				
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
