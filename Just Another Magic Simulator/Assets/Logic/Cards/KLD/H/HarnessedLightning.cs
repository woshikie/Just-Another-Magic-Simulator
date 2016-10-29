
using System.Collections;

namespace Card
{
	public class HarnessedLightning : Card
	{
		/*
		Choose target creature. You get {E}{E}{E} (three energy counters), then you may pay any amount of {E}. Harnessed Lightning deals that much damage to that creature.
		*/
		private const string UniqueCardName = "Harnessed Lightning";
		public HarnessedLightning() : base(UniqueCardName) {
				
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
