
using System.Collections;

namespace Card
{
	public class FailedInspection : Card
	{
		/*
		Counter target spell. Draw a card, then discard a card.
		*/
		private const string UniqueCardName = "Failed Inspection";
		public FailedInspection() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "instant" };
			Colors = new string[] { "blue" };
			SubTypes = new string[] {  };
			SuperTypes = new string[] {  };
		}

	}
}
