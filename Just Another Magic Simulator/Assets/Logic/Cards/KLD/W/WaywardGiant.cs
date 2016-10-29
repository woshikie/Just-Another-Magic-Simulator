
using System.Collections;

namespace Card
{
	public class WaywardGiant : Card
	{
		/*
		Menace
		*/
		private const string UniqueCardName = "Wayward Giant";
		public WaywardGiant() : base(UniqueCardName) {
				
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
