
using System.Collections;

namespace Card
{
	public class GearseekerSerpent : Card
	{
		/*
		Gearseeker Serpent costs {1} less to cast for each artifact you control.
{5}{U}: Gearseeker Serpent can't be blocked this turn.
		*/
		private const string UniqueCardName = "Gearseeker Serpent";
		public GearseekerSerpent() : base(UniqueCardName) {
				
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
