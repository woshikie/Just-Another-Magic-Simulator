
using System.Collections;

namespace Card
{
	public class CreepingMold : Card
	{
		/*
		Destroy target artifact, enchantment, or land.
		*/
		private const string UniqueCardName = "Creeping Mold";
		public CreepingMold() : base(UniqueCardName) {
				
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
