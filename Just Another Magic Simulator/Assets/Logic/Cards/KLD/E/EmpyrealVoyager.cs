
using System.Collections;

namespace Card
{
	public class EmpyrealVoyager : Card
	{
		/*
		Flying, trample
Whenever Empyreal Voyager deals combat damage to a player, you get that many {E} (energy counters).
		*/
		private const string UniqueCardName = "Empyreal Voyager";
		public EmpyrealVoyager() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "creature" };
			Colors = new string[] { "blue", "blue" };
			SubTypes = new string[] { "scout", "scout" };
			SuperTypes = new string[] {  };
		}

	}
}
