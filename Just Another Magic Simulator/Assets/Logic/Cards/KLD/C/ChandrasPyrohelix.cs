
using System.Collections;

namespace Card
{
	public class ChandrasPyrohelix : Card
	{
		/*
		Chandra's Pyrohelix deals 2 damage divided as you choose among one or two target creatures and/or players.
		*/
		private const string UniqueCardName = "Chandra's Pyrohelix";
		public ChandrasPyrohelix() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "instant" };
			Colors = new string[] { "red" };
			SubTypes = new string[] {  };
			SuperTypes = new string[] {  };
		}

	}
}
