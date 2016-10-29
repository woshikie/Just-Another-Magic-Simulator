
using System.Collections;

namespace Card
{
	public class AetherMeltdown : Card
	{
		/*
		Flash (You may cast this spell any time you could cast an instant.)
Enchant creature or Vehicle
When Aether Meltdown enters the battlefield, you get {E}{E} (two energy counters).
Enchanted permanent gets -4/-0.
		*/
		private const string UniqueCardName = "Aether Meltdown";
		public AetherMeltdown() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "enchantment" };
			Colors = new string[] { "blue" };
			SubTypes = new string[] { "aura" };
			SuperTypes = new string[] {  };
		}

	}
}
