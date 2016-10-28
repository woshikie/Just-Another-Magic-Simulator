
using System.Collections;

namespace Card
{
    public class MidnightOil : Card
    {
        /*
        Midnight Oil enters the battlefield with seven hour counters on it.
At the beginning of your draw step, draw an additional card and remove two hour counters from Midnight Oil.
Your maximum hand size is equal to the number of hour counters on Midnight Oil.
Whenever you discard a card, you lose 1 life.
        */
        private const string UniqueCardName = "Midnight Oil";
        public MidnightOil() : base(UniqueCardName) { }

    }
}
