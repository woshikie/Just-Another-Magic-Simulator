
using System.Collections;

namespace Card
{
	public class DhundOperative : Card
	{
		/*
		As long as you control an artifact, Dhund Operative gets +1/+0 and has deathtouch. (Any amount of damage it deals to a creature is enough to destroy it.)
		*/
		private const string UniqueCardName = "Dhund Operative";
		public DhundOperative() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "creature" };
			Colors = new string[] { "black" };
			SubTypes = new string[] { "human", "human" };
			SuperTypes = new string[] {  };
		}

	}
}
