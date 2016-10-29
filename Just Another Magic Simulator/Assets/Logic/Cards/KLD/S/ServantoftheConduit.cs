
using System.Collections;

namespace Card
{
	public class ServantoftheConduit : Card
	{
		/*
		When Servant of the Conduit enters the battlefield, you get {E}{E} (two energy counters).
{T}, Pay {E}: Add one mana of any color to your mana pool.
		*/
		private const string UniqueCardName = "Servant of the Conduit";
		public ServantoftheConduit() : base(UniqueCardName) {
				
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
