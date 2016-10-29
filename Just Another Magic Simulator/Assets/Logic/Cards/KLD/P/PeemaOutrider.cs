
using System.Collections;

namespace Card
{
	public class PeemaOutrider : Card
	{
		/*
		Trample
Fabricate 1 (When this creature enters the battlefield, put a +1/+1 counter on it or create a 1/1 colorless Servo artifact creature token.)
		*/
		private const string UniqueCardName = "Peema Outrider";
		public PeemaOutrider() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] {  };
			Colors = new string[] {  };
			SubTypes = new string[] { "elf", "elf" };
			SuperTypes = new string[] {  };
		}

	}
}
