
using System.Collections;

namespace Card
{
	public class EliminatetheCompetition : Card
	{
		/*
		As an additional cost to cast Eliminate the Competition, sacrifice X creatures.
Destroy X target creatures.
		*/
		private const string UniqueCardName = "Eliminate the Competition";
		public EliminatetheCompetition() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "sorcery" };
			Colors = new string[] { "black" };
			SubTypes = new string[] {  };
			SuperTypes = new string[] {  };
		}

	}
}
