
using System.Collections;

namespace Card
{
	public class GiantSpectacle : Card
	{
		/*
		Enchant creature
Enchanted creature gets +2/+1 and has menace.
		*/
		private const string UniqueCardName = "Giant Spectacle";
		public GiantSpectacle() : base(UniqueCardName) {
				
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
