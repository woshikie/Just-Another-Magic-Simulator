
using System.Collections;

namespace Card
{
	public class InventorsApprentice : Card
	{
		/*
		Inventor's Apprentice gets +1/+1 as long as you control an artifact.
		*/
		private const string UniqueCardName = "Inventor's Apprentice";
		public InventorsApprentice() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] {  };
			Colors = new string[] {  };
			SubTypes = new string[] { "human", "human" };
			SuperTypes = new string[] {  };
		}

	}
}
