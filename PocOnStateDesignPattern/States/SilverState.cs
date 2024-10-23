using PocOnStateDesignPattern.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocOnStateDesignPattern.States
{
    internal class SilverState : State
    {
        const double minBalance = 5000;
        const double maxBalance = 9999;
        public SilverState() : base(minBalance,maxBalance) { }
        public override string GetBenefits()
        {
            return $"\nSwitched OR Trnasit to Silver State :\n" +
                $"As A Loyal Silver Member, You Can Enjoy A 3% Cashback On Every Transaction You Make!";
        }
    }
}
