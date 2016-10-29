
using System.Collections;

namespace Card
{
	public class ÆtherTradewinds : Card
	{
		/*
		Return target permanent you control and target permanent you don't control to their owners' hands.
		*/
		private const string UniqueCardName = "Æther Tradewinds";
		public ÆtherTradewinds() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "instant" };
			Colors = new string[] { "blue" };
			SubTypes = new string[] {  };
			SuperTypes = new string[] {  };
		}

	}
}
