
using System.Collections;

namespace Card
{
	public class RiparianTiger : Card
	{
		/*
		Trample
When Riparian Tiger enters the battlefield, you get {E}{E} (two energy counters).
Whenever Riparian Tiger attacks, you may pay {E}{E}. If you do, it gets +2/+2 until end of turn.
		*/
		private const string UniqueCardName = "Riparian Tiger";
		public RiparianTiger() : base(UniqueCardName) {
				
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
