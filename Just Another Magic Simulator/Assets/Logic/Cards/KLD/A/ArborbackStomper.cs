
using System.Collections;

namespace Card
{
	public class ArborbackStomper : Card
	{
		/*
		Trample
When Arborback Stomper enters the battlefield, you gain 5 life.
		*/
		private const string UniqueCardName = "Arborback Stomper";
		public ArborbackStomper() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "creature" };
			Colors = new string[] { "green" };
			SubTypes = new string[] { "beast" };
			SuperTypes = new string[] {  };
		}

	}
}
