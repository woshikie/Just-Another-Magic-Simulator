
using System.Collections;

namespace Card
{
	public class OviyaPashiriSageLifecrafter : Card
	{
		/*
		{2}{G}, {T}: Create a 1/1 colorless Servo artifact creature token.
{4}{G}, {T}: Create an X/X colorless Construct artifact creature token, where X is the number of creatures you control.
		*/
		private const string UniqueCardName = "Oviya Pashiri, Sage Lifecrafter";
		public OviyaPashiriSageLifecrafter() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] {  };
			Colors = new string[] {  };
			SubTypes = new string[] { "human", "human" };
			SuperTypes = new string[] {  };
		}

	}
}
