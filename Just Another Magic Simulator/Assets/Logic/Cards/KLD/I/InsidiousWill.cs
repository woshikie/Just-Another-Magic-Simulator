
using System.Collections;

namespace Card
{
	public class InsidiousWill : Card
	{
		/*
		Choose one —
• Counter target spell.
• You may choose new targets for target spell.
• Copy target instant or sorcery spell. You may choose new targets for the copy.
		*/
		private const string UniqueCardName = "Insidious Will";
		public InsidiousWill() : base(UniqueCardName) {
				
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
