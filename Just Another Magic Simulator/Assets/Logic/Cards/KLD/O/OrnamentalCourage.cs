
using System.Collections;

namespace Card
{
	public class OrnamentalCourage : Card
	{
		/*
		Untap target creature. It gets +1/+3 until end of turn.
		*/
		private const string UniqueCardName = "Ornamental Courage";
		public OrnamentalCourage() : base(UniqueCardName) {
				
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
