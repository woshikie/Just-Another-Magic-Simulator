
using System.Collections;

namespace Card
{
	public class CultivatorsCaravan : Card
	{
		/*
		{T}: Add one mana of any color to your mana pool.
Crew 3 (Tap any number of creatures you control with total power 3 or more: This Vehicle becomes an artifact creature until end of turn.)
		*/
		private const string UniqueCardName = "Cultivator's Caravan";
		public CultivatorsCaravan() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "artifact" };
			Colors = new string[] {  };
			SubTypes = new string[] { "vehicle" };
			SuperTypes = new string[] {  };
		}

	}
}
