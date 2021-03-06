
using System.Collections;

namespace Card
{
	public class DiabolicTutor : Card
	{
		/*
		Search your library for a card and put that card into your hand. Then shuffle your library.
		*/
		private const string UniqueCardName = "Diabolic Tutor";
		public DiabolicTutor() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "sorcery" };
			Colors = new string[] { "black" };
			SubTypes = new string[] {  };
			SuperTypes = new string[] {  };
		}

	}
}
