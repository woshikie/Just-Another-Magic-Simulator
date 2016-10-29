
using System.Collections;

namespace Card
{
	public class VedalkenBlademaster : Card
	{
		/*
		Prowess (Whenever you cast a noncreature spell, this creature gets +1/+1 until end of turn.)
		*/
		private const string UniqueCardName = "Vedalken Blademaster";
		public VedalkenBlademaster() : base(UniqueCardName) {
				
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
