
using System.Collections;

namespace Card
{
	public class CommencementofFestivities : Card
	{
		/*
		Prevent all combat damage that would be dealt to players this turn.
		*/
		private const string UniqueCardName = "Commencement of Festivities";
		public CommencementofFestivities() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "instant" };
			Colors = new string[] { "green" };
			SubTypes = new string[] {  };
			SuperTypes = new string[] {  };
		}

	}
}
