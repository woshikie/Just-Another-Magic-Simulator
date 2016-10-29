
using System.Collections;

namespace Card
{
	public class ConsulateSurveillance : Card
	{
		/*
		When Consulate Surveillance enters the battlefield, you get {E}{E}{E}{E} (four energy counters).
Pay {E}{E}: Prevent all damage that would be dealt to you this turn by a source of your choice.
		*/
		private const string UniqueCardName = "Consulate Surveillance";
		public ConsulateSurveillance() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "enchantment" };
			Colors = new string[] { "white" };
			SubTypes = new string[] {  };
			SuperTypes = new string[] {  };
		}

	}
}
