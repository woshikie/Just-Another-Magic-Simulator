
using System.Collections;

namespace Card
{
	public class VerdurousGearhulk : Card
	{
		/*
		Trample
When Verdurous Gearhulk enters the battlefield, distribute four +1/+1 counters among any number of target creatures you control.
		*/
		private const string UniqueCardName = "Verdurous Gearhulk";
		public VerdurousGearhulk() : base(UniqueCardName) {
				
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
