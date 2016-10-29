
using System.Collections;

namespace Card
{
	public class FretworkColony : Card
	{
		/*
		Fretwork Colony can't block.
At the beginning of your upkeep, put a +1/+1 counter on Fretwork Colony and you lose 1 life.
		*/
		private const string UniqueCardName = "Fretwork Colony";
		public FretworkColony() : base(UniqueCardName) {
				
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
