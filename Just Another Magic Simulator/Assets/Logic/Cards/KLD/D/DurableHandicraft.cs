
using System.Collections;

namespace Card
{
	public class DurableHandicraft : Card
	{
		/*
		Whenever a creature enters the battlefield under your control, you may pay {1}. If you do, put a +1/+1 counter on that creature.
{5}{G}, Sacrifice Durable Handicraft: Put a +1/+1 counter on each creature you control.
		*/
		private const string UniqueCardName = "Durable Handicraft";
		public DurableHandicraft() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "enchantment" };
			Colors = new string[] { "green" };
			SubTypes = new string[] {  };
			SuperTypes = new string[] {  };
		}

	}
}
