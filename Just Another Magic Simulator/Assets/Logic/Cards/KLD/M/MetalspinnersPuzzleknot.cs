
using System.Collections;

namespace Card
{
	public class MetalspinnersPuzzleknot : Card
	{
		/*
		When Metalspinner's Puzzleknot enters the battlefield, you draw a card and you lose 1 life.
{2}{B}, Sacrifice Metalspinner's Puzzleknot: You draw a card and you lose 1 life.
		*/
		private const string UniqueCardName = "Metalspinner's Puzzleknot";
		public MetalspinnersPuzzleknot() : base(UniqueCardName) {
				
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
