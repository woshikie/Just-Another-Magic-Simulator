
using System.Collections;

namespace Card
{
	public class ShrewdNegotiation : Card
	{
		/*
		Exchange control of target artifact you control and target artifact or creature you don't control.
		*/
		private const string UniqueCardName = "Shrewd Negotiation";
		public ShrewdNegotiation() : base(UniqueCardName) {
				
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
