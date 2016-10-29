
using System.Collections;

namespace Card
{
	public class CeremoniousRejection : Card
	{
		/*
		Counter target colorless spell.
		*/
		private const string UniqueCardName = "Ceremonious Rejection";
		public CeremoniousRejection() : base(UniqueCardName) {
				
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
