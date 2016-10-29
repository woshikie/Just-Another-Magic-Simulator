
using System.Collections;

namespace Card
{
	public class SubtleStrike : Card
	{
		/*
		Choose one or both —
• Target creature gets -1/-1 until end of turn.
• Put a +1/+1 counter on target creature.
		*/
		private const string UniqueCardName = "Subtle Strike";
		public SubtleStrike() : base(UniqueCardName) {
				
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
