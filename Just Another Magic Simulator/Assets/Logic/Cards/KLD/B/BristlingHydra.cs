
using System.Collections;

namespace Card
{
	public class BristlingHydra : Card
	{
		/*
		When Bristling Hydra enters the battlefield, you get {E}{E}{E} (three energy counters).
Pay {E}{E}{E}: Put a +1/+1 counter on Bristling Hydra. It gains hexproof until end of turn.
		*/
		private const string UniqueCardName = "Bristling Hydra";
		public BristlingHydra() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "creature" };
			Colors = new string[] { "green" };
			SubTypes = new string[] { "hydra" };
			SuperTypes = new string[] {  };
		}

	}
}
