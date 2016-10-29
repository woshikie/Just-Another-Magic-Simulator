
using System.Collections;

namespace Card
{
	public class PressurePoint : Card
	{
		/*
		Tap target creature.
Draw a card.
		*/
		private const string UniqueCardName = "Pressure Point";
		public PressurePoint() : base(UniqueCardName) {
				
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
