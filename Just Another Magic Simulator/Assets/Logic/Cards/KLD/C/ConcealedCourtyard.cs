
using System.Collections;

namespace Card
{
	public class ConcealedCourtyard : Card
	{
		/*
		Concealed Courtyard enters the battlefield tapped unless you control two or fewer other lands.
{T}: Add {W} or {B} to your mana pool.
		*/
		private const string UniqueCardName = "Concealed Courtyard";
		public ConcealedCourtyard() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "land" };
			Colors = new string[] {  };
			SubTypes = new string[] {  };
			SuperTypes = new string[] {  };
		}

	}
}
