
using System.Collections;

namespace Card
{
	public class AviaryMechanic : Card
	{
		/*
		When Aviary Mechanic enters the battlefield, you may return another permanent you control to its owner's hand.
		*/
		private const string UniqueCardName = "Aviary Mechanic";
		public AviaryMechanic() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "creature" };
			Colors = new string[] { "white" };
			SubTypes = new string[] { "artificer", "artificer" };
			SuperTypes = new string[] {  };
		}

	}
}
