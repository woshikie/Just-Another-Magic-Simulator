
using System.Collections;

namespace Card
{
	public class ImpeccableTiming : Card
	{
		/*
		Impeccable Timing deals 3 damage to target attacking or blocking creature.
		*/
		private const string UniqueCardName = "Impeccable Timing";
		public ImpeccableTiming() : base(UniqueCardName) {
				
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
