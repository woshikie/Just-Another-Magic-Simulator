
using System.Collections;

namespace Card
{
	public class DepalaPilotExemplar : Card
	{
		/*
		Other Dwarves you control get +1/+1.
Each Vehicle you control gets +1/+1 as long as it's a creature.
Whenever Depala, Pilot Exemplar becomes tapped, you may pay {X}. If you do, reveal the top X cards of your library, put all Dwarf and Vehicle cards from among them into your hand, then put the rest on the bottom of your library in a random order.
		*/
		private const string UniqueCardName = "Depala, Pilot Exemplar";
		public DepalaPilotExemplar() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "creature" };
			Colors = new string[] { "red", "red" };
			SubTypes = new string[] { "dwarf", "dwarf" };
			SuperTypes = new string[] { "legendary" };
		}

	}
}
