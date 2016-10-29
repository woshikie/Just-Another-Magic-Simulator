
using System.Collections;

namespace Card
{
	public class KambalConsulofAllocation : Card
	{
		/*
		Whenever an opponent casts a noncreature spell, that player loses 2 life and you gain 2 life.
		*/
		private const string UniqueCardName = "Kambal, Consul of Allocation";
		public KambalConsulofAllocation() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] {  };
			Colors = new string[] { "white", "white" };
			SubTypes = new string[] { "human", "human" };
			SuperTypes = new string[] {  };
		}

	}
}
