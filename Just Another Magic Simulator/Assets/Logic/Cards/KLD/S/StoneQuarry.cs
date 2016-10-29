
using System.Collections;

namespace Card
{
	public class StoneQuarry : Card
	{
		/*
		Stone Quarry enters the battlefield tapped.
{T}: Add {R} or {W} to your mana pool.
		*/
		private const string UniqueCardName = "Stone Quarry";
		public StoneQuarry() : base(UniqueCardName) {
				
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
