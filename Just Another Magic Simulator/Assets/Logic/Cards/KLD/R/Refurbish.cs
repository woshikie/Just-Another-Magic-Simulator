
using System.Collections;

namespace Card
{
	public class Refurbish : Card
	{
		/*
		Return target artifact card from your graveyard to the battlefield.
		*/
		private const string UniqueCardName = "Refurbish";
		public Refurbish() : base(UniqueCardName) {
				
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
