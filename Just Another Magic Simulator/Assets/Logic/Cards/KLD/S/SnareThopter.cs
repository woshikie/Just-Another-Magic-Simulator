
using System.Collections;

namespace Card
{
	public class SnareThopter : Card
	{
		/*
		Flying, haste
		*/
		private const string UniqueCardName = "Snare Thopter";
		public SnareThopter() : base(UniqueCardName) {
				
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
