
using System.Collections;

namespace Card
{
	public class NaturesWay : Card
	{
		/*
		Target creature you control gains vigilance and trample until end of turn. It deals damage equal to its power to target creature you don't control.
		*/
		private const string UniqueCardName = "Nature's Way";
		public NaturesWay() : base(UniqueCardName) {
				
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
