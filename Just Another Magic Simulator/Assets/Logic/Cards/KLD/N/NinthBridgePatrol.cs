
using System.Collections;

namespace Card
{
	public class NinthBridgePatrol : Card
	{
		/*
		Whenever another creature you control leaves the battlefield, put a +1/+1 counter on Ninth Bridge Patrol.
		*/
		private const string UniqueCardName = "Ninth Bridge Patrol";
		public NinthBridgePatrol() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] {  };
			Colors = new string[] {  };
			SubTypes = new string[] { "soldier", "soldier" };
			SuperTypes = new string[] {  };
		}

	}
}
