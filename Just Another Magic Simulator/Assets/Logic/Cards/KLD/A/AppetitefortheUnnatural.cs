
using System.Collections;

namespace Card
{
	public class AppetitefortheUnnatural : Card
	{
		/*
		Destroy target artifact or enchantment. You gain 2 life.
		*/
		private const string UniqueCardName = "Appetite for the Unnatural";
		public AppetitefortheUnnatural() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "instant" };
			Colors = new string[] { "green" };
			SubTypes = new string[] {  };
			SuperTypes = new string[] {  };
		}

	}
}
