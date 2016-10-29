
using System.Collections;

namespace Card
{
	public class TerroroftheFairgrounds : Card
	{
		/*
		
		*/
		private const string UniqueCardName = "Terror of the Fairgrounds";
		public TerroroftheFairgrounds() : base(UniqueCardName) {
				
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
