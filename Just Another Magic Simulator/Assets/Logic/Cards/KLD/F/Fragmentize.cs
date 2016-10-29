
using System.Collections;

namespace Card
{
	public class Fragmentize : Card
	{
		/*
		Destroy target artifact or enchantment with converted mana cost 4 or less.
		*/
		private const string UniqueCardName = "Fragmentize";
		public Fragmentize() : base(UniqueCardName) {
				
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
