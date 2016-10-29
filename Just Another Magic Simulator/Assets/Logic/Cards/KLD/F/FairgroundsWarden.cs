
using System.Collections;

namespace Card
{
	public class FairgroundsWarden : Card
	{
		/*
		When Fairgrounds Warden enters the battlefield, exile target creature an opponent controls until Fairgrounds Warden leaves the battlefield.
		*/
		private const string UniqueCardName = "Fairgrounds Warden";
		public FairgroundsWarden() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "creature" };
			Colors = new string[] { "white" };
			SubTypes = new string[] { "dwarf", "dwarf" };
			SuperTypes = new string[] {  };
		}

	}
}
