
using System.Collections;

namespace Card
{
	public class DieYoung : Card
	{
		/*
		Choose target creature. You get {E}{E} (two energy counters), then you may pay any amount of {E}. The creature gets -1/-1 until end of turn for each {E} paid this way.
		*/
		private const string UniqueCardName = "Die Young";
		public DieYoung() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "sorcery" };
			Colors = new string[] { "black" };
			SubTypes = new string[] {  };
			SuperTypes = new string[] {  };
		}

	}
}
