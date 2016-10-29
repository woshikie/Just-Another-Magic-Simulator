
using System.Collections;

namespace Card
{
	public class Swamp : Card
	{
		/*
		
		*/
		private const string UniqueCardName = "Swamp";
		public Swamp() : base(UniqueCardName) {
				
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
