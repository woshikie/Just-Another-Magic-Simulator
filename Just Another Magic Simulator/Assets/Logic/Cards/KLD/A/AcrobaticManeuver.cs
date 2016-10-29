
using System.Collections;

namespace Card
{
	public class AcrobaticManeuver : Card
	{
		/*
		Exile target creature you control, then return that card to the battlefield under its owner's control.
Draw a card.
		*/
		private const string UniqueCardName = "Acrobatic Maneuver";
		public AcrobaticManeuver() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "instant" };
			Colors = new string[] { "white" };
			SubTypes = new string[] {  };
			SuperTypes = new string[] {  };
		}

	}
}
