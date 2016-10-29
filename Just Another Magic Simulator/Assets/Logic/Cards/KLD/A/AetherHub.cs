
using System.Collections;

namespace Card
{
	public class AetherHub : Card
	{
		/*
		When Aether Hub enters the battlefield, you get {E} (an energy counter).
{T}: Add {C} to your mana pool.
{T}, Pay {E}: Add one mana of any color to your mana pool.
		*/
		private const string UniqueCardName = "Aether Hub";
		public AetherHub() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "land" };
			Colors = new string[] {  };
			SubTypes = new string[] {  };
			SuperTypes = new string[] {  };
		}

	}
}
