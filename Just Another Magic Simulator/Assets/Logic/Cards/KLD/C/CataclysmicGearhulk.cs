
using System.Collections;

namespace Card
{
	public class CataclysmicGearhulk : Card
	{
		/*
		Vigilance
When Cataclysmic Gearhulk enters the battlefield, each player chooses an artifact, a creature, an enchantment, and a planeswalker from among the nonland permanents he or she controls, then sacrifices the rest.
		*/
		private const string UniqueCardName = "Cataclysmic Gearhulk";
		public CataclysmicGearhulk() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "artifact", "artifact" };
			Colors = new string[] { "white" };
			SubTypes = new string[] { "construct" };
			SuperTypes = new string[] {  };
		}

	}
}
