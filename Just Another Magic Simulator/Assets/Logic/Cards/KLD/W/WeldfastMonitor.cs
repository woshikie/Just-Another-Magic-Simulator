
using System.Collections;

namespace Card
{
	public class WeldfastMonitor : Card
	{
		/*
		{R}: Weldfast Monitor gains menace until end of turn.
		*/
		private const string UniqueCardName = "Weldfast Monitor";
		public WeldfastMonitor() : base(UniqueCardName) {
				
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
