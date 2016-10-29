
using System.Collections;

namespace Card
{
	public class EagerConstruct : Card
	{
		/*
		When Eager Construct enters the battlefield, each player may scry 1. (To scry 1, look at the top card of your library, then you may put that card on the bottom of your library.)
		*/
		private const string UniqueCardName = "Eager Construct";
		public EagerConstruct() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "artifact", "artifact" };
			Colors = new string[] {  };
			SubTypes = new string[] { "construct" };
			SuperTypes = new string[] {  };
		}

	}
}
