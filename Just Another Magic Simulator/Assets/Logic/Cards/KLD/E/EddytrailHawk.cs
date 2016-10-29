
using System.Collections;

namespace Card
{
	public class EddytrailHawk : Card
	{
		/*
		Flying
When Eddytrail Hawk enters the battlefield, you get {E}{E} (two energy counters).
Whenever Eddytrail Hawk attacks, you may pay {E}. If you do, another target attacking creature gains flying until end of turn.
		*/
		private const string UniqueCardName = "Eddytrail Hawk";
		public EddytrailHawk() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "creature" };
			Colors = new string[] { "white" };
			SubTypes = new string[] { "bird" };
			SuperTypes = new string[] {  };
		}

	}
}
