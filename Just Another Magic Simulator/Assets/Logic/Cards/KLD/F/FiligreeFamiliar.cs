
using System.Collections;

namespace Card
{
	public class FiligreeFamiliar : Card
	{
		/*
		When Filigree Familiar enters the battlefield, you gain 2 life.
When Filigree Familiar dies, draw a card.
		*/
		private const string UniqueCardName = "Filigree Familiar";
		public FiligreeFamiliar() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "artifact", "artifact" };
			Colors = new string[] {  };
			SubTypes = new string[] { "fox" };
			SuperTypes = new string[] {  };
		}

	}
}
