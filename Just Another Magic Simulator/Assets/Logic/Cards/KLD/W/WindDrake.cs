
using System.Collections;

namespace Card
{
	public class WindDrake : Card
	{
		/*
		Flying
		*/
		private const string UniqueCardName = "Wind Drake";
		public WindDrake() : base(UniqueCardName) {
				
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
