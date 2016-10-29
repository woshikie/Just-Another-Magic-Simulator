
using System.Collections;

namespace Card
{
	public class CatharticReunion : Card
	{
		/*
		As an additional cost to cast Cathartic Reunion, discard two cards.
Draw three cards.
		*/
		private const string UniqueCardName = "Cathartic Reunion";
		public CatharticReunion() : base(UniqueCardName) {
				
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
