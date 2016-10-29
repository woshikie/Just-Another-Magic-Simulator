
using System.Collections;

namespace Card
{
	public class FoundryInspector : Card
	{
		/*
		Artifact spells you cast cost {1} less to cast.
		*/
		private const string UniqueCardName = "Foundry Inspector";
		public FoundryInspector() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "artifact", "artifact" };
			Colors = new string[] {  };
			SubTypes = new string[] { "construct" };
			SuperTypes = new string[] {  };
		}

	}
}
