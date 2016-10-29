
using System.Collections;

namespace Card
{
	public class ElectrostaticPummeler : Card
	{
		/*
		When Electrostatic Pummeler enters the battlefield, you get {E}{E}{E} (three energy counters).
Pay {E}{E}{E}: Electrostatic Pummeler gets +X/+X until end of turn, where X is its power.
		*/
		private const string UniqueCardName = "Electrostatic Pummeler";
		public ElectrostaticPummeler() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "artifact", "artifact" };
			Colors = new string[] {  };
			SubTypes = new string[] { "construct" };
			SuperTypes = new string[] {  };
		}

	}
}
