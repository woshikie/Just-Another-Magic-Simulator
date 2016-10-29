
using System.Collections;

namespace Card
{
	public class ParadoxicalOutcome : Card
	{
		/*
		Return any number of target nonland, nontoken permanents you control to their owners' hands. Draw a card for each card returned to your hand this way.
		*/
		private const string UniqueCardName = "Paradoxical Outcome";
		public ParadoxicalOutcome() : base(UniqueCardName) {
				
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
