
using System.Collections;

namespace Card
{
	public class ThrivingIbex : Card
	{
		/*
		When Thriving Ibex enters the battlefield, you get {E}{E} (two energy counters).
Whenever Thriving Ibex attacks, you may pay {E}{E}. If you do, put a +1/+1 counter on it.
		*/
		private const string UniqueCardName = "Thriving Ibex";
		public ThrivingIbex() : base(UniqueCardName) {
				
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
