
using System.Collections;

namespace Card
{
	public class DukharaScavenger : Card
	{
		/*
		When Dukhara Scavenger enters the battlefield, you may put target artifact or creature card from your graveyard on top of your library.
		*/
		private const string UniqueCardName = "Dukhara Scavenger";
		public DukharaScavenger() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "creature" };
			Colors = new string[] { "black" };
			SubTypes = new string[] { "crocodile" };
			SuperTypes = new string[] {  };
		}

	}
}
