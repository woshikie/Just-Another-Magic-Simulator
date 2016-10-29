
using System.Collections;

namespace Card
{
	public class RenegadeFirebrand : Card
	{
		/*
		As long as you control a Chandra planeswalker, Renegade Firebrand gets +1/+0 and has first strike. (It deals combat damage before creatures without first strike.)
		*/
		private const string UniqueCardName = "Renegade Firebrand";
		public RenegadeFirebrand() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] {  };
			Colors = new string[] {  };
			SubTypes = new string[] { "warrior", "warrior" };
			SuperTypes = new string[] {  };
		}

	}
}
