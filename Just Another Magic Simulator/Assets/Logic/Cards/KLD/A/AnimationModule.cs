
using System.Collections;

namespace Card
{
	public class AnimationModule : Card
	{
		/*
		Whenever one or more +1/+1 counters are placed on a permanent you control, you may pay {1}. If you do, create a 1/1 colorless Servo artifact creature token.
{3}, {T}: Choose a counter on target permanent or player. Give that permanent or player another counter of that kind.
		*/
		private const string UniqueCardName = "Animation Module";
		public AnimationModule() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "artifact" };
			Colors = new string[] {  };
			SubTypes = new string[] {  };
			SuperTypes = new string[] {  };
		}

	}
}
