
using System.Collections;

namespace Card
{
	public class ConfiscationCoup : Card
	{
		/*
		Choose target artifact or creature. You get {E}{E}{E}{E} (four energy counters), then you may pay an amount of {E} equal to that permanent's converted mana cost. If you do, gain control of it.
		*/
		private const string UniqueCardName = "Confiscation Coup";
		public ConfiscationCoup() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "sorcery" };
			Colors = new string[] { "blue" };
			SubTypes = new string[] {  };
			SuperTypes = new string[] {  };
		}

	}
}
