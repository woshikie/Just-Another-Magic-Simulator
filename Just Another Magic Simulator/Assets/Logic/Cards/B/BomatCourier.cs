
using System.Collections;

namespace Card
{
    public class BomatCourier : Card
    {
        /*
        Haste
Whenever Bomat Courier attacks, exile the top card of your library face down. (You can't look at it.)
{R}, Discard your hand, Sacrifice Bomat Courier: Put all cards exiled with Bomat Courier into their owners' hands.
        */
        private const string UniqueCardName = "Bomat Courier";
        public BomatCourier() : base(UniqueCardName) { }

    }
}
