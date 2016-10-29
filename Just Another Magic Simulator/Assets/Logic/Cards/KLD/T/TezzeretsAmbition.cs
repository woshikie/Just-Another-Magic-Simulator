
using System.Collections;

namespace Card
{
	public class TezzeretsAmbition : Card
	{
		/*
		Draw three cards. If you control no artifacts, discard a card.
		*/
		private const string UniqueCardName = "Tezzeret's Ambition";
		public TezzeretsAmbition() : base(UniqueCardName) {
				
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
