
using System.Collections;

namespace Card
{
	public class IncendiarySabotage : Card
	{
		/*
		As an additional cost to cast Incendiary Sabotage, sacrifice an artifact.
Incendiary Sabotage deals 3 damage to each creature.
		*/
		private const string UniqueCardName = "Incendiary Sabotage";
		public IncendiarySabotage() : base(UniqueCardName) {
				
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
