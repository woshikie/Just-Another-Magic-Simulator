
using System.Collections;

namespace Card
{
	public class AetherbornMarauder : Card
	{
		/*
		Flying, lifelink
When Aetherborn Marauder enters the battlefield, move any number of +1/+1 counters from other permanents you control onto Aetherborn Marauder.
		*/
		private const string UniqueCardName = "Aetherborn Marauder";
		public AetherbornMarauder() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "creature" };
			Colors = new string[] { "black" };
			SubTypes = new string[] { "aetherborn", "aetherborn" };
			SuperTypes = new string[] {  };
		}

	}
}
