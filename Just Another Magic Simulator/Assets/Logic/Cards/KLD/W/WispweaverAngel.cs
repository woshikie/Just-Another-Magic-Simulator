
using System.Collections;

namespace Card
{
	public class WispweaverAngel : Card
	{
		/*
		Flying
When Wispweaver Angel enters the battlefield, you may exile another target creature you control, then return that card to the battlefield under its owner's control.
		*/
		private const string UniqueCardName = "Wispweaver Angel";
		public WispweaverAngel() : base(UniqueCardName) {
				
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
