
using System.Collections;

namespace Card
{
	public class ThrivingRats : Card
	{
		/*
		When Thriving Rats enters the battlefield, you get {E}{E} (two energy counters).
Whenever Thriving Rats attacks, you may pay {E}{E}. If you do, put a +1/+1 counter on it.
		*/
		private const string UniqueCardName = "Thriving Rats";
		public ThrivingRats() : base(UniqueCardName) {
				
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
