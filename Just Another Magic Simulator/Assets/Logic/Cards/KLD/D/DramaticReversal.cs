
using System.Collections;

namespace Card
{
	public class DramaticReversal : Card
	{
		/*
		Untap all nonland permanents you control.
		*/
		private const string UniqueCardName = "Dramatic Reversal";
		public DramaticReversal() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "instant" };
			Colors = new string[] { "blue" };
			SubTypes = new string[] {  };
			SuperTypes = new string[] {  };
		}

	}
}
