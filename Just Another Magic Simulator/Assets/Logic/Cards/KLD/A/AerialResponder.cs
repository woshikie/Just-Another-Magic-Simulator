
using System.Collections;

namespace Card
{
	public class AerialResponder : Card
	{
		/*
		Flying, vigilance, lifelink
		*/
		private const string UniqueCardName = "Aerial Responder";
		public AerialResponder() : base(UniqueCardName) {
				
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
