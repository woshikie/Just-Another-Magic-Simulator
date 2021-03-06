
using System.Collections;

namespace Card
{
	public class FoundryScreecher : Card
	{
		/*
		Flying
Foundry Screecher gets +1/+0 as long as you control an artifact.
		*/
		private const string UniqueCardName = "Foundry Screecher";
		public FoundryScreecher() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "creature" };
			Colors = new string[] { "black" };
			SubTypes = new string[] { "bat" };
			SuperTypes = new string[] {  };
		}

	}
}
