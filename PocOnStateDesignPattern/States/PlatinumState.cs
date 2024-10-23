using PocOnStateDesignPattern.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocOnStateDesignPattern.States
{
    internal class PlatinumState : State
    {
        const double minBalance = 20000;
        const double maxBalance = 49999;
        public PlatinumState() : base(minBalance, maxBalance) { }
        public override string GetBenefits()
        {
            return $"\nSwitched OR Trnasit to Platinum State :\n" +
                $"As An Exclusive Platinum Member, You Will Receive A Special 7% Cashback On Every Transaction!";
        }
       
    }
}
