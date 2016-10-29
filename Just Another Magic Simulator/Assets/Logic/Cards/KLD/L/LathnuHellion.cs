
using System.Collections;

namespace Card
{
	public class LathnuHellion : Card
	{
		/*
		Haste
When Lathnu Hellion enters the battlefield, you get {E}{E} (two energy counters).
At the beginning of your end step, sacrifice Lathnu Hellion unless you pay {E}{E}.
		*/
		private const string UniqueCardName = "Lathnu Hellion";
		public LathnuHellion() : base(UniqueCardName) {
				
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
