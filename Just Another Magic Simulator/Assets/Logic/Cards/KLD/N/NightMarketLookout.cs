
using System.Collections;

namespace Card
{
	public class NightMarketLookout : Card
	{
		/*
		Whenever Night Market Lookout becomes tapped, each opponent loses 1 life and you gain 1 life.
		*/
		private const string UniqueCardName = "Night Market Lookout";
		public NightMarketLookout() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] {  };
			Colors = new string[] {  };
			SubTypes = new string[] { "rogue", "rogue" };
			SuperTypes = new string[] {  };
		}

	}
}
