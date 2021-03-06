
using System.Collections;

namespace Card
{
	public class AuthorityoftheConsuls : Card
	{
		/*
		Creatures your opponents control enter the battlefield tapped.
Whenever a creature enters the battlefield under an opponent's control, you gain 1 life.
		*/
		private const string UniqueCardName = "Authority of the Consuls";
		public AuthorityoftheConsuls() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "enchantment" };
			Colors = new string[] { "white" };
			SubTypes = new string[] {  };
			SuperTypes = new string[] {  };
		}

	}
}
