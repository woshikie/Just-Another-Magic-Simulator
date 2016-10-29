
using System.Collections;

namespace Card
{
	public class Fumigate : Card
	{
		/*
		Destroy all creatures. You gain 1 life for each creature destroyed this way.
		*/
		private const string UniqueCardName = "Fumigate";
		public Fumigate() : base(UniqueCardName) {
				
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
