
using System.Collections;

namespace Card
{
	public class ThrivingRhino : Card
	{
		/*
		When Thriving Rhino enters the battlefield, you get {E}{E} (two energy counters).
Whenever Thriving Rhino attacks, you may pay {E}{E}. If you do, put a +1/+1 counter on it.
		*/
		private const string UniqueCardName = "Thriving Rhino";
		public ThrivingRhino() : base(UniqueCardName) {
				
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
