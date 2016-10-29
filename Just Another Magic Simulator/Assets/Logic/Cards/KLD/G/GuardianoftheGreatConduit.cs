
using System.Collections;

namespace Card
{
	public class GuardianoftheGreatConduit : Card
	{
		/*
		Reach (This creature can block creatures with flying.)
As long as you control a Nissa planeswalker, Guardian of the Great Conduit gets +2/+0 and has vigilance. (Attacking doesn't cause it to tap.)
		*/
		private const string UniqueCardName = "Guardian of the Great Conduit";
		public GuardianoftheGreatConduit() : base(UniqueCardName) {
				
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
