
using System.Collections;

namespace Card
{
	public class AradaraExpress : Card
	{
		/*
		Menace
Crew 4 (Tap any number of creatures you control with total power 4 or more: This Vehicle becomes an artifact creature until end of turn.)
		*/
		private const string UniqueCardName = "Aradara Express";
		public AradaraExpress() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "artifact" };
			Colors = new string[] {  };
			SubTypes = new string[] { "vehicle" };
			SuperTypes = new string[] {  };
		}

	}
}
