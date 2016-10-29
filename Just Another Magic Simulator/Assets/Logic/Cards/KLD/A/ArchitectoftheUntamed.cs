
using System.Collections;

namespace Card
{
	public class ArchitectoftheUntamed : Card
	{
		/*
		Whenever a land enters the battlefield under your control, you get {E} (an energy counter).
Pay {E}{E}{E}{E}{E}{E}{E}{E}: Create a 6/6 colorless Beast artifact creature token.
		*/
		private const string UniqueCardName = "Architect of the Untamed";
		public ArchitectoftheUntamed() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "creature" };
			Colors = new string[] { "green" };
			SubTypes = new string[] { "artificer", "artificer", "artificer" };
			SuperTypes = new string[] {  };
		}

	}
}
