
using System.Collections;

namespace Card
{
	public class TasseledDromedary : Card
	{
		/*
		
		*/
		private const string UniqueCardName = "Tasseled Dromedary";
		public TasseledDromedary() : base(UniqueCardName) {
				
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
