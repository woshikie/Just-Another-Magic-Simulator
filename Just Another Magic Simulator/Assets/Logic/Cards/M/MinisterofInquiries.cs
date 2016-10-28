
using System.Collections;

namespace Card
{
    public class MinisterofInquiries : Card
    {
        /*
        When Minister of Inquiries enters the battlefield, you get {E}{E} (two energy counters).
{T}, Pay {E}: Target player puts the top three cards of his or her library into his or her graveyard.
        */
        private const string UniqueCardName = "Minister of Inquiries";
        public MinisterofInquiries() : base(UniqueCardName) { }

    }
}
