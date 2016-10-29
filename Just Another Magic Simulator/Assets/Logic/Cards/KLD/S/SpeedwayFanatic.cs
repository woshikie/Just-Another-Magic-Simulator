
using System.Collections;

namespace Card
{
	public class SpeedwayFanatic : Card
	{
		/*
		Haste
Whenever Speedway Fanatic crews a Vehicle, that Vehicle gains haste until end of turn.
		*/
		private const string UniqueCardName = "Speedway Fanatic";
		public SpeedwayFanatic() : base(UniqueCardName) {
				
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
