
using System.Collections;

namespace Card
{
	public class AngelofInvention : Card
	{
		/*
		Flying, vigilance, lifelink
Fabricate 2 (When this creature enters the battlefield, put two +1/+1 counters on it or create two 1/1 colorless Servo artifact creature tokens.)
Other creatures you control get +1/+1.
		*/
		private const string UniqueCardName = "Angel of Invention";
		public AngelofInvention() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "creature" };
			Colors = new string[] { "white" };
			SubTypes = new string[] { "angel" };
			SuperTypes = new string[] {  };
		}

	}
}
