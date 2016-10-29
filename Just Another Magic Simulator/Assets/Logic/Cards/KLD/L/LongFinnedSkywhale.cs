
using System.Collections;

namespace Card
{
	public class LongFinnedSkywhale : Card
	{
		/*
		Flying
Long-Finned Skywhale can block only creatures with flying.
		*/
		private const string UniqueCardName = "Long-Finned Skywhale";
		public LongFinnedSkywhale() : base(UniqueCardName) {
				
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
