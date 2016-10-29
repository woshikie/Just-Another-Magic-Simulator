
using System.Collections;

namespace Card
{
	public class PrakhataClubSecurity : Card
	{
		/*
		
		*/
		private const string UniqueCardName = "Prakhata Club Security";
		public PrakhataClubSecurity() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] {  };
			Colors = new string[] {  };
			SubTypes = new string[] { "warrior", "warrior" };
			SuperTypes = new string[] {  };
		}

	}
}
