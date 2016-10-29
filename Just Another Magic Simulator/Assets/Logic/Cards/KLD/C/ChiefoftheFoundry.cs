
using System.Collections;

namespace Card
{
	public class ChiefoftheFoundry : Card
	{
		/*
		Other artifact creatures you control get +1/+1.
		*/
		private const string UniqueCardName = "Chief of the Foundry";
		public ChiefoftheFoundry() : base(UniqueCardName) {
				
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
