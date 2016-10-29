
using System.Collections;

namespace Card
{
	public class RenegadeTactics : Card
	{
		/*
		Target creature can't block this turn.
Draw a card.
		*/
		private const string UniqueCardName = "Renegade Tactics";
		public RenegadeTactics() : base(UniqueCardName) {
				
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
