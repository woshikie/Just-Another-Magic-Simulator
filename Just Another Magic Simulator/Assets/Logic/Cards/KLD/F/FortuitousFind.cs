
using System.Collections;

namespace Card
{
	public class FortuitousFind : Card
	{
		/*
		Choose one or both —
• Return target artifact card from your graveyard to your hand.
• Return target creature card from your graveyard to your hand.
		*/
		private const string UniqueCardName = "Fortuitous Find";
		public FortuitousFind() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "sorcery" };
			Colors = new string[] { "black" };
			SubTypes = new string[] {  };
			SuperTypes = new string[] {  };
		}

	}
}
