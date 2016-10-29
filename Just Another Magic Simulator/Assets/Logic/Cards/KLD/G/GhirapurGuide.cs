
using System.Collections;

namespace Card
{
	public class GhirapurGuide : Card
	{
		/*
		{2}{G}: Target creature you control can't be blocked by creatures with power 2 or less this turn.
		*/
		private const string UniqueCardName = "Ghirapur Guide";
		public GhirapurGuide() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] {  };
			Colors = new string[] {  };
			SubTypes = new string[] { "scout", "scout" };
			SuperTypes = new string[] {  };
		}

	}
}
