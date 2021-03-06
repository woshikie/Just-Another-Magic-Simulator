
using System.Collections;

namespace Card
{
	public class NarnamCobra : Card
	{
		/*
		{G}: Narnam Cobra gains deathtouch until end of turn. (Any amount of damage it deals to a creature is enough to destroy it.)
		*/
		private const string UniqueCardName = "Narnam Cobra";
		public NarnamCobra() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "creature", "creature" };
			Colors = new string[] {  };
			SubTypes = new string[] {  };
			SuperTypes = new string[] {  };
		}

	}
}
