
using System.Collections;

namespace Card
{
	public class OvalchaseDaredevil : Card
	{
		/*
		Whenever an artifact enters the battlefield under your control, you may return Ovalchase Daredevil from your graveyard to your hand.
		*/
		private const string UniqueCardName = "Ovalchase Daredevil";
		public OvalchaseDaredevil() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] {  };
			Colors = new string[] {  };
			SubTypes = new string[] { "pilot", "pilot" };
			SuperTypes = new string[] {  };
		}

	}
}
