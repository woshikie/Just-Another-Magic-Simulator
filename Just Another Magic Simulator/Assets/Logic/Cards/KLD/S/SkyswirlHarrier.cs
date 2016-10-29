
using System.Collections;

namespace Card
{
	public class SkyswirlHarrier : Card
	{
		/*
		Flying
		*/
		private const string UniqueCardName = "Skyswirl Harrier";
		public SkyswirlHarrier() : base(UniqueCardName) {
				
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
