
using System.Collections;

namespace Card
{
	public class NissaNaturesArtisan : Card
	{
		/*
		+3: You gain 3 life.
−4: Reveal the top two cards of your library. Put all land cards from among them onto the battlefield and the rest into your hand.
−12: Creatures you control get +5/+5 and gain trample until end of turn.
		*/
		private const string UniqueCardName = "Nissa, Nature's Artisan";
		public NissaNaturesArtisan() : base(UniqueCardName) {
				
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
