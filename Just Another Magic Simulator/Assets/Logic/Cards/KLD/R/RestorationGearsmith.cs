
using System.Collections;

namespace Card
{
	public class RestorationGearsmith : Card
	{
		/*
		When Restoration Gearsmith enters the battlefield, return target artifact or creature card from your graveyard to your hand.
		*/
		private const string UniqueCardName = "Restoration Gearsmith";
		public RestorationGearsmith() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] {  };
			Colors = new string[] { "white", "white" };
			SubTypes = new string[] { "human", "human" };
			SuperTypes = new string[] {  };
		}

	}
}
