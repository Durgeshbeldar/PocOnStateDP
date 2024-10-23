using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocOnStateDesignPattern.States
{
    // Interface for state
    abstract class State 
    {
        public double MinBalance { get; set; }
        public double MaxBalance { get; set; }
        public State(double minBalance, double maxBalance) 
        { 
            MinBalance = minBalance;
            MaxBalance = maxBalance;
        }

        public abstract string GetBenefits();
    }
}
