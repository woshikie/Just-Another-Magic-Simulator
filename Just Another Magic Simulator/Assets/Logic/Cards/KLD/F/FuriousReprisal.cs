
using System.Collections;

namespace Card
{
	public class FuriousReprisal : Card
	{
		/*
		Furious Reprisal deals 2 damage to each of two target creatures and/or players.
		*/
		private const string UniqueCardName = "Furious Reprisal";
		public FuriousReprisal() : base(UniqueCardName) {
				
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
