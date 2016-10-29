
using System.Collections;

namespace Card
{
	public class CogworkersPuzzleknot : Card
	{
		/*
		When Cogworker's Puzzleknot enters the battlefield, create a 1/1 colorless Servo artifact creature token.
{1}{W}, Sacrifice Cogworker's Puzzleknot: Create a 1/1 colorless Servo artifact creature token.
		*/
		private const string UniqueCardName = "Cogworker's Puzzleknot";
		public CogworkersPuzzleknot() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "artifact" };
			Colors = new string[] {  };
			SubTypes = new string[] {  };
			SuperTypes = new string[] {  };
		}

	}
}
