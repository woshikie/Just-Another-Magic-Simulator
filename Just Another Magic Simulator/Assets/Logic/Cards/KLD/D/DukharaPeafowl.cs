
using System.Collections;

namespace Card
{
	public class DukharaPeafowl : Card
	{
		/*
		{U}: Dukhara Peafowl gains flying until end of turn.
		*/
		private const string UniqueCardName = "Dukhara Peafowl";
		public DukharaPeafowl() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "artifact", "artifact" };
			Colors = new string[] {  };
			SubTypes = new string[] { "bird" };
			SuperTypes = new string[] {  };
		}

	}
}
