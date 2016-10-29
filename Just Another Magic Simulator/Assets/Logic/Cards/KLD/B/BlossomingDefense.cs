
using System.Collections;

namespace Card
{
	public class BlossomingDefense : Card
	{
		/*
		Target creature you control gets +2/+2 and gains hexproof until end of turn.
		*/
		private const string UniqueCardName = "Blossoming Defense";
		public BlossomingDefense() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "instant" };
			Colors = new string[] { "green" };
			SubTypes = new string[] {  };
			SuperTypes = new string[] {  };
		}

	}
}
