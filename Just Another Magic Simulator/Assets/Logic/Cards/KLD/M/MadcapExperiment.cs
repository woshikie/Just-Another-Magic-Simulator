
using System.Collections;

namespace Card
{
	public class MadcapExperiment : Card
	{
		/*
		Reveal cards from the top of your library until you reveal an artifact card. Put that card onto the battlefield and the rest on the bottom of your library in a random order. Madcap Experiment deals damage to you equal to the number of cards revealed this way.
		*/
		private const string UniqueCardName = "Madcap Experiment";
		public MadcapExperiment() : base(UniqueCardName) {
				
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
