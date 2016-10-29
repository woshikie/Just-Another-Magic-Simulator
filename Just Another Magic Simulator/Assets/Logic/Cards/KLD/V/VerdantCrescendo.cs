
using System.Collections;

namespace Card
{
	public class VerdantCrescendo : Card
	{
		/*
		Search your library for a basic land card and put it onto the battlefield tapped. Search your library and graveyard for a card named Nissa, Nature's Artisan, reveal it, and put it into your hand. Then shuffle your library.
		*/
		private const string UniqueCardName = "Verdant Crescendo";
		public VerdantCrescendo() : base(UniqueCardName) {
				
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
