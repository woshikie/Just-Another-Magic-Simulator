
using System.Collections;

namespace Card
{
	public class SkywhalersShot : Card
	{
		/*
		Destroy target creature with power 3 or greater. Scry 1.
		*/
		private const string UniqueCardName = "Skywhaler's Shot";
		public SkywhalersShot() : base(UniqueCardName) {
				
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
