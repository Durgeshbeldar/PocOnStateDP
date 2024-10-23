using PocOnStateDesignPattern.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocOnStateDesignPattern.States
{
    internal class BasicState : State
    {
        const double minBalance = 0;
        const double maxBalance = 4999;
        public BasicState() : base(minBalance, maxBalance) { }
        public override string GetBenefits()
        {
            return $"\nAssigned Basic State :\n" +
                $"Your Account Is Currently Under The Basic Plan, So You Are Not Eligible For Cashback Benefits. " +
                $"Please Upgrade Your Account To Enjoy Exclusive Offers!";
        }

      
    }
}
