
using System.Collections;

namespace Card
{
    public class MorbidCuriosity : Card
    {
        /*
        As an additional cost to cast Morbid Curiosity, sacrifice an artifact or creature.
Draw cards equal to the converted mana cost of the sacrificed permanent.
        */
        private const string UniqueCardName = "Morbid Curiosity";
        public MorbidCuriosity() : base(UniqueCardName) { }

    }
}
