
using System.Collections;

namespace Card
{
	public class SalivatingGremlins : Card
	{
		/*
		Whenever an artifact enters the battlefield under your control, Salivating Gremlins gets +2/+0 and gains trample until end of turn.
		*/
		private const string UniqueCardName = "Salivating Gremlins";
		public SalivatingGremlins() : base(UniqueCardName) {
				
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
