
using System.Collections;

namespace Card
{
	public class NimbleInnovator : Card
	{
		/*
		When Nimble Innovator enters the battlefield, draw a card.
		*/
		private const string UniqueCardName = "Nimble Innovator";
		public NimbleInnovator() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] {  };
			Colors = new string[] {  };
			SubTypes = new string[] { "vedalken", "vedalken" };
			SuperTypes = new string[] {  };
		}

	}
}
