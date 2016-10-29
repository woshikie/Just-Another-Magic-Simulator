
using System.Collections;

namespace Card
{
	public class QuicksmithGenius : Card
	{
		/*
		Whenever an artifact enters the battlefield under your control, you may discard a card. If you do, draw a card.
		*/
		private const string UniqueCardName = "Quicksmith Genius";
		public QuicksmithGenius() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] {  };
			Colors = new string[] {  };
			SubTypes = new string[] { "human", "human" };
			SuperTypes = new string[] {  };
		}

	}
}
