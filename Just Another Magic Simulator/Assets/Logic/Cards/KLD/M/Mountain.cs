
using System.Collections;

namespace Card
{
	public class Mountain : Card
	{
		/*
		
		*/
		private const string UniqueCardName = "Mountain";
		public Mountain() : base(UniqueCardName) {
				
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
