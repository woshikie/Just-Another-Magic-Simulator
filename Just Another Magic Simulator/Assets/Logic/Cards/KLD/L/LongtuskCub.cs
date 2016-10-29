
using System.Collections;

namespace Card
{
	public class LongtuskCub : Card
	{
		/*
		Whenever Longtusk Cub deals combat damage to a player, you get {E}{E} (two energy counters).
Pay {E}{E}: Put a +1/+1 counter on Longtusk Cub.
		*/
		private const string UniqueCardName = "Longtusk Cub";
		public LongtuskCub() : base(UniqueCardName) {
				
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
