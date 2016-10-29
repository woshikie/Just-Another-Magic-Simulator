
using System.Collections;

namespace Card
{
	public class WeldfastWingsmith : Card
	{
		/*
		Whenever an artifact enters the battlefield under your control, Weldfast Wingsmith gains flying until end of turn.
		*/
		private const string UniqueCardName = "Weldfast Wingsmith";
		public WeldfastWingsmith() : base(UniqueCardName) {
				
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
