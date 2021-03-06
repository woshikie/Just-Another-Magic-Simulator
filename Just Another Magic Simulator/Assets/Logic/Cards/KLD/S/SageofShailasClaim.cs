
using System.Collections;

namespace Card
{
	public class SageofShailasClaim : Card
	{
		/*
		When Sage of Shaila's Claim enters the battlefield, you get {E}{E}{E} (three energy counters).
		*/
		private const string UniqueCardName = "Sage of Shaila's Claim";
		public SageofShailasClaim() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] {  };
			Colors = new string[] {  };
			SubTypes = new string[] { "elf", "elf" };
			SuperTypes = new string[] {  };
		}

	}
}
