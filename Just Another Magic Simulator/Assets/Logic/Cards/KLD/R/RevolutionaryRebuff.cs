
using System.Collections;

namespace Card
{
	public class RevolutionaryRebuff : Card
	{
		/*
		Counter target nonartifact spell unless its controller pays {2}.
		*/
		private const string UniqueCardName = "Revolutionary Rebuff";
		public RevolutionaryRebuff() : base(UniqueCardName) {
				
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
