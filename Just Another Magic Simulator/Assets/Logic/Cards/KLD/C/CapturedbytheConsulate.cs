
using System.Collections;

namespace Card
{
	public class CapturedbytheConsulate : Card
	{
		/*
		Enchant creature you don't control
Enchanted creature can't attack.
Whenever an opponent casts a spell, if it has a single target, change the target to enchanted creature if able.
		*/
		private const string UniqueCardName = "Captured by the Consulate";
		public CapturedbytheConsulate() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "enchantment" };
			Colors = new string[] { "white" };
			SubTypes = new string[] { "aura" };
			SuperTypes = new string[] {  };
		}

	}
}
