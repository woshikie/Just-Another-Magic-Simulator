
using System.Collections;

namespace Card
{
	public class WeldingSparks : Card
	{
		/*
		Welding Sparks deals X damage to target creature, where X is 3 plus the number of artifacts you control.
		*/
		private const string UniqueCardName = "Welding Sparks";
		public WeldingSparks() : base(UniqueCardName) {
				
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
