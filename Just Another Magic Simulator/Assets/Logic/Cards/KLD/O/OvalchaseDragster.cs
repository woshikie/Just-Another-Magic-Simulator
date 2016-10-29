
using System.Collections;

namespace Card
{
	public class OvalchaseDragster : Card
	{
		/*
		Trample, haste
Crew 1 (Tap any number of creatures you control with total power 1 or more: This Vehicle becomes an artifact creature until end of turn.)
		*/
		private const string UniqueCardName = "Ovalchase Dragster";
		public OvalchaseDragster() : base(UniqueCardName) {
				
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
