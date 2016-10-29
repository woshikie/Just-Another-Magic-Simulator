
using System.Collections;

namespace Card
{
	public class FlameLash : Card
	{
		/*
		Flame Lash deals 4 damage to target creature or player.
		*/
		private const string UniqueCardName = "Flame Lash";
		public FlameLash() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "instant" };
			Colors = new string[] { "red" };
			SubTypes = new string[] {  };
			SuperTypes = new string[] {  };
		}

	}
}
