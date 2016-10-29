
using System.Collections;

namespace Card
{
	public class SparkofCreativity : Card
	{
		/*
		Choose target creature. Exile the top card of your library. You may have Spark of Creativity deal damage to that creature equal to the exiled card's converted mana cost. If you don't, you may play that card until end of turn.
		*/
		private const string UniqueCardName = "Spark of Creativity";
		public SparkofCreativity() : base(UniqueCardName) {
				
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
