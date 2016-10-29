
using System.Collections;

namespace Card
{
	public class InventorsFair : Card
	{
		/*
		At the beginning of your upkeep, if you control three or more artifacts, you gain 1 life.
{T}: Add {C} to your mana pool.
{4}, {T}, Sacrifice Inventors' Fair: Search your library for an artifact card, reveal it, put it into your hand, then shuffle your library. Activate this ability only if you control three or more artifacts.
		*/
		private const string UniqueCardName = "Inventors' Fair";
		public InventorsFair() : base(UniqueCardName) {
				
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
