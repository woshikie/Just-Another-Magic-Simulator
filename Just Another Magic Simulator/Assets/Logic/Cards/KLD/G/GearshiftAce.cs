
using System.Collections;

namespace Card
{
	public class GearshiftAce : Card
	{
		/*
		First strike
Whenever Gearshift Ace crews a Vehicle, that Vehicle gains first strike until end of turn.
		*/
		private const string UniqueCardName = "Gearshift Ace";
		public GearshiftAce() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] {  };
			Colors = new string[] {  };
			SubTypes = new string[] { "pilot", "pilot" };
			SuperTypes = new string[] {  };
		}

	}
}
