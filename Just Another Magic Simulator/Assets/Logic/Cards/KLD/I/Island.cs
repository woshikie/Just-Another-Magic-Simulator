
using System.Collections;

namespace Card
{
	public class Island : Card
	{
		/*
		
		*/
		private const string UniqueCardName = "Island";
		public Island() : base(UniqueCardName) {
				
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
