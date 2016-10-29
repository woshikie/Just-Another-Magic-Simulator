
using System.Collections;

namespace Card
{
	public class CurioVendor : Card
	{
		/*
		
		*/
		private const string UniqueCardName = "Curio Vendor";
		public CurioVendor() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "creature" };
			Colors = new string[] { "blue" };
			SubTypes = new string[] { "vedalken" };
			SuperTypes = new string[] {  };
		}

	}
}
