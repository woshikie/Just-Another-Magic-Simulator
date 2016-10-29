
using System.Collections;

namespace Card
{
	public class MetallurgicSummonings : Card
	{
		/*
		Whenever you cast an instant or sorcery spell, create an X/X colorless Construct artifact creature token, where X is that spell's converted mana cost.
{3}{U}{U}, Exile Metallurgic Summonings: Return all instant and sorcery cards from your graveyard to your hand. Activate this ability only if you control six or more artifacts.
		*/
		private const string UniqueCardName = "Metallurgic Summonings";
		public MetallurgicSummonings() : base(UniqueCardName) {
				
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
