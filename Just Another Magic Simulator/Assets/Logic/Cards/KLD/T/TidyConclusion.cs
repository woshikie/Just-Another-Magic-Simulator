
using System.Collections;

namespace Card
{
	public class TidyConclusion : Card
	{
		/*
		Destroy target creature. You gain 1 life for each artifact you control.
		*/
		private const string UniqueCardName = "Tidy Conclusion";
		public TidyConclusion() : base(UniqueCardName) {
				
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
