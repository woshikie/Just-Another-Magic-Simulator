
using System.Collections;

namespace Card
{
	public class EngineeredMight : Card
	{
		/*
		Choose one —
• Target creature gets +5/+5 and gains trample until end of turn.
• Creatures you control get +2/+2 and gain vigilance until end of turn.
		*/
		private const string UniqueCardName = "Engineered Might";
		public EngineeredMight() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "sorcery" };
			Colors = new string[] { "green", "green" };
			SubTypes = new string[] {  };
			SuperTypes = new string[] {  };
		}

	}
}
