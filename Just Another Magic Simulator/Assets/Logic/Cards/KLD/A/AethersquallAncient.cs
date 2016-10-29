
using System.Collections;

namespace Card
{
	public class AethersquallAncient : Card
	{
		/*
		Flying
At the beginning of your upkeep, you get {E}{E}{E} (three energy counters).
Pay {E}{E}{E}{E}{E}{E}{E}{E}: Return all other creatures to their owners' hands. Activate this ability only any time you could cast a sorcery.
		*/
		private const string UniqueCardName = "Aethersquall Ancient";
		public AethersquallAncient() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "creature" };
			Colors = new string[] { "blue" };
			SubTypes = new string[] { "leviathan" };
			SuperTypes = new string[] {  };
		}

	}
}
