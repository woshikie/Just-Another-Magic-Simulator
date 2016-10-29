
using System.Collections;

namespace Card
{
	public class SmugglersCopter : Card
	{
		/*
		Flying
Whenever Smuggler's Copter attacks or blocks, you may draw a card. If you do, discard a card.
Crew 1 (Tap any number of creatures you control with total power 1 or more: This Vehicle becomes an artifact creature until end of turn.)
		*/
		private const string UniqueCardName = "Smuggler's Copter";
		public SmugglersCopter() : base(UniqueCardName) {
				
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
