
using System.Collections;

namespace Card
{
	public class Forest : Card
	{
		/*
		
		*/
		private const string UniqueCardName = "Forest";
		public Forest() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "land" };
			Colors = new string[] {  };
			SubTypes = new string[] { "forest" };
			SuperTypes = new string[] { "basic" };
		}

	}
}
