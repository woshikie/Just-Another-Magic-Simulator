
using System.Collections;

namespace Card
{
	public class SpiresideInfiltrator : Card
	{
		/*
		Whenever Spireside Infiltrator becomes tapped, it deals 1 damage to each opponent.
		*/
		private const string UniqueCardName = "Spireside Infiltrator";
		public SpiresideInfiltrator() : base(UniqueCardName) {
				
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
