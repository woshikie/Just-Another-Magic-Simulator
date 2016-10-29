
using System.Collections;

namespace Card
{
	public class LiveFast : Card
	{
		/*
		You draw two cards, lose 2 life, and get {E}{E} (two energy counters).
		*/
		private const string UniqueCardName = "Live Fast";
		public LiveFast() : base(UniqueCardName) {
				
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
