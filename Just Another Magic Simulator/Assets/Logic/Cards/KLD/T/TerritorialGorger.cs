
using System.Collections;

namespace Card
{
	public class TerritorialGorger : Card
	{
		/*
		Trample
Whenever you get one or more {E} (energy counters), Territorial Gorger gets +2/+2 until end of turn.
		*/
		private const string UniqueCardName = "Territorial Gorger";
		public TerritorialGorger() : base(UniqueCardName) {
				
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
