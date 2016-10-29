
using System.Collections;

namespace Card
{
	public class HunttheWeak : Card
	{
		/*
		Put a +1/+1 counter on target creature you control. Then that creature fights target creature you don't control. (Each deals damage equal to its power to the other.)
		*/
		private const string UniqueCardName = "Hunt the Weak";
		public HunttheWeak() : base(UniqueCardName) {
				
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
