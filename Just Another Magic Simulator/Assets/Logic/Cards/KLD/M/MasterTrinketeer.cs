
using System.Collections;

namespace Card
{
	public class MasterTrinketeer : Card
	{
		/*
		Servos and Thopters you control get +1/+1.
{3}{W}: Create a 1/1 colorless Servo artifact creature token.
		*/
		private const string UniqueCardName = "Master Trinketeer";
		public MasterTrinketeer() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] {  };
			Colors = new string[] {  };
			SubTypes = new string[] { "dwarf", "dwarf" };
			SuperTypes = new string[] {  };
		}

	}
}
