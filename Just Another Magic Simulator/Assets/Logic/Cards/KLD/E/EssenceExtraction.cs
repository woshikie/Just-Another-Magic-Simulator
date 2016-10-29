
using System.Collections;

namespace Card
{
	public class EssenceExtraction : Card
	{
		/*
		Essence Extraction deals 3 damage to target creature and you gain 3 life.
		*/
		private const string UniqueCardName = "Essence Extraction";
		public EssenceExtraction() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "instant" };
			Colors = new string[] { "black" };
			SubTypes = new string[] {  };
			SuperTypes = new string[] {  };
		}

	}
}
