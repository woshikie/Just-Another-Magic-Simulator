
using System.Collections;

namespace Card
{
	public class PropellerPioneer : Card
	{
		/*
		Flying
Fabricate 1 (When this creature enters the battlefield, put a +1/+1 counter on it or create a 1/1 colorless Servo artifact creature token.)
		*/
		private const string UniqueCardName = "Propeller Pioneer";
		public PropellerPioneer() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] {  };
			Colors = new string[] {  };
			SubTypes = new string[] { "human", "human" };
			SuperTypes = new string[] {  };
		}

	}
}
