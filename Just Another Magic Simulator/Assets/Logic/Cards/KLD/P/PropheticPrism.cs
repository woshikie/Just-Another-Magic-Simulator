
using System.Collections;

namespace Card
{
	public class PropheticPrism : Card
	{
		/*
		When Prophetic Prism enters the battlefield, draw a card.
{1}, {T}: Add one mana of any color to your mana pool.
		*/
		private const string UniqueCardName = "Prophetic Prism";
		public PropheticPrism() : base(UniqueCardName) {
				
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
