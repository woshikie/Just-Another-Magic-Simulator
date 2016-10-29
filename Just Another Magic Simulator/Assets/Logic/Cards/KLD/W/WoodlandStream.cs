
using System.Collections;

namespace Card
{
	public class WoodlandStream : Card
	{
		/*
		Woodland Stream enters the battlefield tapped.
{T}: Add {G} or {U} to your mana pool.
		*/
		private const string UniqueCardName = "Woodland Stream";
		public WoodlandStream() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] {  };
			Colors = new string[] {  };
			SubTypes = new string[] {  };
			SuperTypes = new string[] {  };
		}

	}
}
