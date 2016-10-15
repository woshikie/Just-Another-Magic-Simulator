using UnityEngine;
using System.Collections;

namespace Card
{
    public class AccomplishedAutomaton : Card
    {
        /*
         * Fabricate 1 (When this creature enters the battlefield, 
         * put a +1/+1 counter on it or create a 1/1 colorless Servo artifact creature token.)
         */
        private const string UniqueCardName = "Accomplished Automaton";
        public AccomplishedAutomaton() : base(UniqueCardName) {}

        public override void OnEnterBattlefield()
        {
            
        }
    }
}
