
using System.Collections;

namespace Card
{
	public class RuinousGremlin : Card
	{
		/*
		{2}{R}, Sacrifice Ruinous Gremlin: Destroy target artifact.
		*/
		private const string UniqueCardName = "Ruinous Gremlin";
		public RuinousGremlin() : base(UniqueCardName) {
				
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
