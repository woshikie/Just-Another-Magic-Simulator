
using System.Collections;

namespace Card
{
	public class LargerThanLife : Card
	{
		/*
		Target creature gets +4/+4 and gains trample until end of turn.
		*/
		private const string UniqueCardName = "Larger Than Life";
		public LargerThanLife() : base(UniqueCardName) {
				
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
