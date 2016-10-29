
using System.Collections;

namespace Card
{
	public class Demolish : Card
	{
		/*
		Destroy target artifact or land.
		*/
		private const string UniqueCardName = "Demolish";
		public Demolish() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "sorcery" };
			Colors = new string[] { "red" };
			SubTypes = new string[] {  };
			SuperTypes = new string[] {  };
		}

	}
}
