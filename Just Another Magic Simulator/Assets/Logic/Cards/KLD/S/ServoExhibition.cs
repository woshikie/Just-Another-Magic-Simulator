
using System.Collections;

namespace Card
{
	public class ServoExhibition : Card
	{
		/*
		Create two 1/1 colorless Servo artifact creature tokens.
		*/
		private const string UniqueCardName = "Servo Exhibition";
		public ServoExhibition() : base(UniqueCardName) {
				
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
