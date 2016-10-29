
using System.Collections;

namespace Card
{
	public class Whirlermaker : Card
	{
		/*
		{4}, {T}: Create a 1/1 colorless Thopter artifact creature token with flying.
		*/
		private const string UniqueCardName = "Whirlermaker";
		public Whirlermaker() : base(UniqueCardName) {
				
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
