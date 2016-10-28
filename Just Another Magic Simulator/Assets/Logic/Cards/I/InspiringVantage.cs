
using System.Collections;

namespace Card
{
    public class InspiringVantage : Card
    {
        /*
        Inspiring Vantage enters the battlefield tapped unless you control two or fewer other lands.
{T}: Add {R} or {W} to your mana pool.
        */
        private const string UniqueCardName = "Inspiring Vantage";
        public InspiringVantage() : base(UniqueCardName) { }

    }
}
