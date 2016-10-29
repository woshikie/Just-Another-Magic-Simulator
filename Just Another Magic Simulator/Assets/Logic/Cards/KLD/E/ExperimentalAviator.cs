
using System.Collections;

namespace Card
{
	public class ExperimentalAviator : Card
	{
		/*
		Flying
When Experimental Aviator enters the battlefield, create two 1/1 colorless Thopter artifact creature tokens with flying.
		*/
		private const string UniqueCardName = "Experimental Aviator";
		public ExperimentalAviator() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "creature" };
			Colors = new string[] { "blue" };
			SubTypes = new string[] { "artificer", "artificer" };
			SuperTypes = new string[] {  };
		}

	}
}
