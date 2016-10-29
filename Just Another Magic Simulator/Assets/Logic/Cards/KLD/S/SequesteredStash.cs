
using System.Collections;

namespace Card
{
	public class SequesteredStash : Card
	{
		/*
		{T}: Add {C} to your mana pool.
{4}, {T}, Sacrifice Sequestered Stash: Put the top five cards of your library into your graveyard. Then you may put an artifact card from your graveyard on top of your library.
		*/
		private const string UniqueCardName = "Sequestered Stash";
		public SequesteredStash() : base(UniqueCardName) {
				
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
