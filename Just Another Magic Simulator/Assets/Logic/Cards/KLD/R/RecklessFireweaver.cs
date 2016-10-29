
using System.Collections;

namespace Card
{
	public class RecklessFireweaver : Card
	{
		/*
		Whenever an artifact enters the battlefield under your control, Reckless Fireweaver deals 1 damage to each opponent.
		*/
		private const string UniqueCardName = "Reckless Fireweaver";
		public RecklessFireweaver() : base(UniqueCardName) {
				
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
