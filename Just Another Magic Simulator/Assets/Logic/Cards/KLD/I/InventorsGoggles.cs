
using System.Collections;

namespace Card
{
	public class InventorsGoggles : Card
	{
		/*
		Equipped creature gets +1/+2.
Whenever an Artificer enters the battlefield under your control, you may attach Inventor's Goggles to it.
Equip {2} ({2}: Attach to target creature you control. Equip only as a sorcery.)
		*/
		private const string UniqueCardName = "Inventor's Goggles";
		public InventorsGoggles() : base(UniqueCardName) {
				
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
