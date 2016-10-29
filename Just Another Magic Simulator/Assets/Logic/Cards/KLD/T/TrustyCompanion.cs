
using System.Collections;

namespace Card
{
	public class TrustyCompanion : Card
	{
		/*
		Vigilance
Trusty Companion can't attack alone.
		*/
		private const string UniqueCardName = "Trusty Companion";
		public TrustyCompanion() : base(UniqueCardName) {
				
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
