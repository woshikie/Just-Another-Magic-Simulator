
using System.Collections;

namespace Card
{
	public class AetherworksMarvel : Card
	{
		/*
		Whenever a permanent you control is put into a graveyard, you get {E} (an energy counter).
{T}, Pay {E}{E}{E}{E}{E}{E}: Look at the top six cards of your library. You may cast a card from among them without paying its mana cost. Put the rest on the bottom of your library in a random order.
		*/
		private const string UniqueCardName = "Aetherworks Marvel";
		public AetherworksMarvel() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "artifact" };
			Colors = new string[] {  };
			SubTypes = new string[] {  };
			SuperTypes = new string[] { "legendary" };
		}

	}
}
