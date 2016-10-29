
using System.Collections;

namespace Card
{
	public class EmbraalBruiser : Card
	{
		/*
		Embraal Bruiser enters the battlefield tapped.
Embraal Bruiser has menace as long as you control an artifact.
		*/
		private const string UniqueCardName = "Embraal Bruiser";
		public EmbraalBruiser() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "creature" };
			Colors = new string[] { "black" };
			SubTypes = new string[] { "human", "human" };
			SuperTypes = new string[] {  };
		}

	}
}
