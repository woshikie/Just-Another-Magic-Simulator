
using System.Collections;

namespace Card
{
	public class RevokePrivileges : Card
	{
		/*
		Enchant creature
Enchanted creature can't attack, block, or crew Vehicles.
		*/
		private const string UniqueCardName = "Revoke Privileges";
		public RevokePrivileges() : base(UniqueCardName) {
				
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
