
using System.Collections;

namespace Card
{
	public class PrakhataPillarBug : Card
	{
		/*
		{B}: Prakhata Pillar-Bug gains lifelink until end of turn. (Damage dealt by this creature also causes you to gain that much life.)
		*/
		private const string UniqueCardName = "Prakhata Pillar-Bug";
		public PrakhataPillarBug() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "creature", "creature" };
			Colors = new string[] {  };
			SubTypes = new string[] {  };
			SuperTypes = new string[] {  };
		}

	}
}
