
using System.Collections;

namespace Card
{
	public class CowlProwler : Card
	{
		/*
		
		*/
		private const string UniqueCardName = "Cowl Prowler";
		public CowlProwler() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "creature" };
			Colors = new string[] { "green" };
			SubTypes = new string[] { "wurm" };
			SuperTypes = new string[] {  };
		}

	}
}
