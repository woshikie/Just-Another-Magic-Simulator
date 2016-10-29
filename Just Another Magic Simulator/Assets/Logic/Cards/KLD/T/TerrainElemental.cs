
using System.Collections;

namespace Card
{
	public class TerrainElemental : Card
	{
		/*
		
		*/
		private const string UniqueCardName = "Terrain Elemental";
		public TerrainElemental() : base(UniqueCardName) {
				
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
