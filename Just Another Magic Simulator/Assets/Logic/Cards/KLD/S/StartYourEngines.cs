
using System.Collections;

namespace Card
{
	public class StartYourEngines : Card
	{
		/*
		Vehicles you control become artifact creatures until end of turn. Creatures you control get +2/+0 until end of turn.
		*/
		private const string UniqueCardName = "Start Your Engines";
		public StartYourEngines() : base(UniqueCardName) {
				
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
