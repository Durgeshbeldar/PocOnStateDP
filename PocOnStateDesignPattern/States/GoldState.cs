using PocOnStateDesignPattern.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocOnStateDesignPattern.States
{
    internal class GoldState : State
    {
        const double minBalance = 10000;
        const double maxBalance = 19999;
        public GoldState() : base(minBalance, maxBalance) { }
        public override string GetBenefits()
        {
            return $"\nSwitched OR Trnasit to Gold State :\n" +
                $"As A Prestigious Gold Member, You Are Entitled To A 5% Cashback On All Your Transactions!";
        }

      
    }
}
