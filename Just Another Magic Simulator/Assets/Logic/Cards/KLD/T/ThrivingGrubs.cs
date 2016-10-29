
using System.Collections;

namespace Card
{
	public class ThrivingGrubs : Card
	{
		/*
		When Thriving Grubs enters the battlefield, you get {E}{E} (two energy counters).
Whenever Thriving Grubs attacks, you may pay {E}{E}. If you do, put a +1/+1 counter on it.
		*/
		private const string UniqueCardName = "Thriving Grubs";
		public ThrivingGrubs() : base(UniqueCardName) {
				
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
