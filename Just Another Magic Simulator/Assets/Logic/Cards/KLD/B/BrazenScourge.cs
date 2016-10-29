
using System.Collections;

namespace Card
{
	public class BrazenScourge : Card
	{
		/*
		Haste
		*/
		private const string UniqueCardName = "Brazen Scourge";
		public BrazenScourge() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "creature" };
			Colors = new string[] { "red" };
			SubTypes = new string[] { "gremlin" };
			SuperTypes = new string[] {  };
		}

	}
}
