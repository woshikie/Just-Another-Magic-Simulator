
using System.Collections;

namespace Card
{
	public class GlimmerofGenius : Card
	{
		/*
		Scry 2, then draw two cards. You get {E}{E} (two energy counters).
		*/
		private const string UniqueCardName = "Glimmer of Genius";
		public GlimmerofGenius() : base(UniqueCardName) {
				
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
