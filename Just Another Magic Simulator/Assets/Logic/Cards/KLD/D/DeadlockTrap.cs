
using System.Collections;

namespace Card
{
	public class DeadlockTrap : Card
	{
		/*
		Deadlock Trap enters the battlefield tapped.
When Deadlock Trap enters the battlefield, you get {E}{E} (two energy counters).
{T}, Pay {E}: Tap target creature or planeswalker. Its activated abilities can't be activated this turn.
		*/
		private const string UniqueCardName = "Deadlock Trap";
		public DeadlockTrap() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "artifact" };
			Colors = new string[] {  };
			SubTypes = new string[] {  };
			SuperTypes = new string[] {  };
		}

	}
}
