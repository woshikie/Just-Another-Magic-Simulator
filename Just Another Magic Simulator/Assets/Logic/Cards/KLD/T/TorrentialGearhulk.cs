
using System.Collections;

namespace Card
{
	public class TorrentialGearhulk : Card
	{
		/*
		Flash
When Torrential Gearhulk enters the battlefield, you may cast target instant card from your graveyard without paying its mana cost. If that card would be put into your graveyard this turn, exile it instead.
		*/
		private const string UniqueCardName = "Torrential Gearhulk";
		public TorrentialGearhulk() : base(UniqueCardName) {
				
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
