
using System.Collections;

namespace Card
{
	public class KujarSeedsculptor : Card
	{
		/*
		When Kujar Seedsculptor enters the battlefield, put a +1/+1 counter on target creature you control.
		*/
		private const string UniqueCardName = "Kujar Seedsculptor";
		public KujarSeedsculptor() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] {  };
			Colors = new string[] {  };
			SubTypes = new string[] { "elf", "elf" };
			SuperTypes = new string[] {  };
		}

	}
}
