
using System.Collections;

namespace Card
{
	public class HightideHermit : Card
	{
		/*
		Defender
When Hightide Hermit enters the battlefield, you get {E}{E}{E}{E} (four energy counters).
Pay {E}{E}: Hightide Hermit can attack this turn as though it didn't have defender.
		*/
		private const string UniqueCardName = "Hightide Hermit";
		public HightideHermit() : base(UniqueCardName) {
				
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
