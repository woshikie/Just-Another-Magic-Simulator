
using System.Collections;

namespace Card
{
	public class Cloudblazer : Card
	{
		/*
		Flying
When Cloudblazer enters the battlefield, you gain 2 life and draw two cards.
		*/
		private const string UniqueCardName = "Cloudblazer";
		public Cloudblazer() : base(UniqueCardName) {
				
		}
		protected override void OnConstructed()
		{
			Types = new string[] { "creature" };
			Colors = new string[] { "blue", "blue" };
			SubTypes = new string[] { "human", "human" };
			SuperTypes = new string[] {  };
		}

	}
}
