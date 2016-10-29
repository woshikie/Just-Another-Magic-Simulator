
using System.Collections;

namespace Card
{
	public class WildestDreams : Card
	{
		/*
		Return X target cards from your graveyard to your hand. Exile Wildest Dreams.
		*/
		private const string UniqueCardName = "Wildest Dreams";
		public WildestDreams() : base(UniqueCardName) {
				
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
