
using System.Collections;

namespace Card
{
	public class NoxiousGearhulk : Card
	{
		/*
		Menace
When Noxious Gearhulk enters the battlefield, you may destroy another target creature. If a creature is destroyed this way, you gain life equal to its toughness.
		*/
		private const string UniqueCardName = "Noxious Gearhulk";
		public NoxiousGearhulk() : base(UniqueCardName) {
				
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
