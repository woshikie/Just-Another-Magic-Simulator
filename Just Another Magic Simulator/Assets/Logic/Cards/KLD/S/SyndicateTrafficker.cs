
using System.Collections;

namespace Card
{
	public class SyndicateTrafficker : Card
	{
		/*
		{1}, Sacrifice an artifact: Put a +1/+1 counter on Syndicate Trafficker. It gains indestructible until end of turn.
		*/
		private const string UniqueCardName = "Syndicate Trafficker";
		public SyndicateTrafficker() : base(UniqueCardName) {
				
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
