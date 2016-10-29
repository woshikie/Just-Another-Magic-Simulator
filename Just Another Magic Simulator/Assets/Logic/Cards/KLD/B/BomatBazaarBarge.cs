
using System.Collections;

namespace Card
{
	public class BomatBazaarBarge : Card
	{
		/*
		When Bomat Bazaar Barge enters the battlefield, draw a card.
Crew 3 (Tap any number of creatures you control with total power 3 or more: This Vehicle becomes an artifact creature until end of turn.)
		*/
		private const string UniqueCardName = "Bomat Bazaar Barge";
		public BomatBazaarBarge() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "artifact" };
			Colors = new string[] {  };
			SubTypes = new string[] { "vehicle" };
			SuperTypes = new string[] {  };
		}

	}
}
