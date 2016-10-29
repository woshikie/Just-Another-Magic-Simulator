
using System.Collections;

namespace Card
{
	public class InspiredCharge : Card
	{
		/*
		Creatures you control get +2/+1 until end of turn.
		*/
		private const string UniqueCardName = "Inspired Charge";
		public InspiredCharge() : base(UniqueCardName) {
				
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
