
using System.Collections;

namespace Card
{
	public class BastionMastodon : Card
	{
		/*
		{W}: Bastion Mastodon gains vigilance until end of turn.
		*/
		private const string UniqueCardName = "Bastion Mastodon";
		public BastionMastodon() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "artifact", "artifact" };
			Colors = new string[] {  };
			SubTypes = new string[] { "elephant" };
			SuperTypes = new string[] {  };
		}

	}
}
