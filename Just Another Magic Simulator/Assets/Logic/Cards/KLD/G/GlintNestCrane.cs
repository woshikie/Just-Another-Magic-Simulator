
using System.Collections;

namespace Card
{
	public class GlintNestCrane : Card
	{
		/*
		Flying
When Glint-Nest Crane enters the battlefield, look at the top four cards of your library. You may reveal an artifact card from among them and put it into your hand. Put the rest on the bottom of your library in any order.
		*/
		private const string UniqueCardName = "Glint-Nest Crane";
		public GlintNestCrane() : base(UniqueCardName) {
				
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
