
using System.Collections;

namespace Card
{
	public class ContrabandKingpin : Card
	{
		/*
		Lifelink
Whenever an artifact enters the battlefield under your control, scry 1.
		*/
		private const string UniqueCardName = "Contraband Kingpin";
		public ContrabandKingpin() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "creature" };
			Colors = new string[] { "black", "black" };
			SubTypes = new string[] { "aetherborn", "aetherborn" };
			SuperTypes = new string[] {  };
		}

	}
}
