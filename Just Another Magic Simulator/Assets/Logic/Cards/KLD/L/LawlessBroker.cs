
using System.Collections;

namespace Card
{
	public class LawlessBroker : Card
	{
		/*
		When Lawless Broker dies, put a +1/+1 counter on target creature you control.
		*/
		private const string UniqueCardName = "Lawless Broker";
		public LawlessBroker() : base(UniqueCardName) {
				
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
