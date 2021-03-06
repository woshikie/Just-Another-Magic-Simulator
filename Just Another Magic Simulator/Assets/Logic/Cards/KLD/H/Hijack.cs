
using System.Collections;

namespace Card
{
	public class Hijack : Card
	{
		/*
		Gain control of target artifact or creature until end of turn. Untap it. It gains haste until end of turn.
		*/
		private const string UniqueCardName = "Hijack";
		public Hijack() : base(UniqueCardName) {
				
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
