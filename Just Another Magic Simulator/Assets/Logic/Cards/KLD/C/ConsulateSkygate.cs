
using System.Collections;

namespace Card
{
	public class ConsulateSkygate : Card
	{
		/*
		Defender
Reach (This creature can block creatures with flying.)
		*/
		private const string UniqueCardName = "Consulate Skygate";
		public ConsulateSkygate() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "artifact", "artifact" };
			Colors = new string[] {  };
			SubTypes = new string[] { "wall" };
			SuperTypes = new string[] {  };
		}

	}
}
