
using System.Collections;

namespace Card
{
	public class MindRot : Card
	{
		/*
		Target player discards two cards.
		*/
		private const string UniqueCardName = "Mind Rot";
		public MindRot() : base(UniqueCardName) {
				
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
