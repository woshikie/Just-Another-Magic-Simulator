
using System.Collections;

namespace Card
{
	public class AetherstormRoc : Card
	{
		/*
		Flying
Whenever Aetherstorm Roc or another creature enters the battlefield under your control, you get {E} (an energy counter).
Whenever Aetherstorm Roc attacks, you may pay {E}{E}. If you do, put a +1/+1 counter on it and tap up to one target creature defending player controls.
		*/
		private const string UniqueCardName = "Aetherstorm Roc";
		public AetherstormRoc() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "creature" };
			Colors = new string[] { "white" };
			SubTypes = new string[] { "bird" };
			SuperTypes = new string[] {  };
		}

	}
}
