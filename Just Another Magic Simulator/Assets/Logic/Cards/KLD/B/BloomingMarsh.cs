
using System.Collections;

namespace Card
{
	public class BloomingMarsh : Card
	{
		/*
		Blooming Marsh enters the battlefield tapped unless you control two or fewer other lands.
{T}: Add {B} or {G} to your mana pool.
		*/
		private const string UniqueCardName = "Blooming Marsh";
		public BloomingMarsh() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "land" };
			Colors = new string[] {  };
			SubTypes = new string[] {  };
			SuperTypes = new string[] {  };
		}

	}
}
