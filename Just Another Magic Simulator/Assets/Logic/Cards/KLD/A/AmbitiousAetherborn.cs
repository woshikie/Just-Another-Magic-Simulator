
using System.Collections;

namespace Card
{
	public class AmbitiousAetherborn : Card
	{
		/*
		Fabricate 1 (When this creature enters the battlefield, put a +1/+1 counter on it or create a 1/1 colorless Servo artifact creature token.)
		*/
		private const string UniqueCardName = "Ambitious Aetherborn";
		public AmbitiousAetherborn() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "creature" };
			Colors = new string[] { "black" };
			SubTypes = new string[] { "aetherborn", "aetherborn" };
			SuperTypes = new string[] {  };
		}

	}
}
