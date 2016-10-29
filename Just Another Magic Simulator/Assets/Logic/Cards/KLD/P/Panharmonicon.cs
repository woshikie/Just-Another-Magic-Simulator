
using System.Collections;

namespace Card
{
	public class Panharmonicon : Card
	{
		/*
		If an artifact or creature entering the battlefield causes a triggered ability of a permanent you control to trigger, that ability triggers an additional time.
		*/
		private const string UniqueCardName = "Panharmonicon";
		public Panharmonicon() : base(UniqueCardName) {
				
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
