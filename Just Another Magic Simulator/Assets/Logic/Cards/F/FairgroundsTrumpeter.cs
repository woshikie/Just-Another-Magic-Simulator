
using System.Collections;

namespace Card
{
    public class FairgroundsTrumpeter : Card
    {
        /*
        At the beginning of each end step, if a +1/+1 counter was placed on a permanent under your control this turn, put a +1/+1 counter on Fairgrounds Trumpeter.
        */
        private const string UniqueCardName = "Fairgrounds Trumpeter";
        public FairgroundsTrumpeter() : base(UniqueCardName) { }

    }
}
