
using System.Collections;

namespace Card
{
	public class MakeObsolete : Card
	{
		/*
		Creatures your opponents control get -1/-1 until end of turn.
		*/
		private const string UniqueCardName = "Make Obsolete";
		public MakeObsolete() : base(UniqueCardName) {
				
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
