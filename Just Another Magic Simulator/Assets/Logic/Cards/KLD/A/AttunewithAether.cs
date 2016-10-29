
using System.Collections;

namespace Card
{
	public class AttunewithAether : Card
	{
		/*
		Search your library for a basic land card, reveal it, put it into your hand, then shuffle your library. You get {E}{E} (two energy counters).
		*/
		private const string UniqueCardName = "Attune with Aether";
		public AttunewithAether() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "sorcery" };
			Colors = new string[] { "green" };
			SubTypes = new string[] {  };
			SuperTypes = new string[] {  };
		}

	}
}
