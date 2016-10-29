
using System.Collections;

namespace Card
{
	public class MultiformWonder : Card
	{
		/*
		When Multiform Wonder enters the battlefield, you get {E}{E}{E} (three energy counters).
Pay {E}: Multiform Wonder gains your choice of flying, vigilance, or lifelink until end of turn.
Pay {E}: Multiform Wonder gets +2/-2 or -2/+2 until end of turn.
		*/
		private const string UniqueCardName = "Multiform Wonder";
		public MultiformWonder() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "creature", "creature" };
			Colors = new string[] {  };
			SubTypes = new string[] {  };
			SuperTypes = new string[] {  };
		}

	}
}
