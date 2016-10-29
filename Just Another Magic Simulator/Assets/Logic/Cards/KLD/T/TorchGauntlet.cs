
using System.Collections;

namespace Card
{
	public class TorchGauntlet : Card
	{
		/*
		Equipped creature gets +2/+0.
Equip {2} ({2}: Attach to target creature you control. Equip only as a sorcery.)
		*/
		private const string UniqueCardName = "Torch Gauntlet";
		public TorchGauntlet() : base(UniqueCardName) {
				
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
