using PocOnStateDesignPattern.States;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PocOnStateDesignPattern.Context
{
    internal class Account
    {
        private State _state {  get; set; }

        private StateManager _manager { get; set; }
        public int AccountNumber { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }

        public Account(int accountNumber, string name, double balance)
        {
            AccountNumber = accountNumber;
            Name = name;
            Balance = balance;
            _state = new BasicState();
            _manager = new StateManager();
        }

        public string WithDrawMoney(double amount)
        {
            if (Balance - amount > 0)
            {
                Balance -= amount;
                EvaluateState();
                return $"The Amount is Withdrawn... Updated Balance is {Balance}";
            }
            return "\nTransaction Failed Due to Insufficient Balance";
        }
        public string DepositMoney(double amount)
        {
            Balance += amount;
            EvaluateState();
            return $"\nThe Amount is Deposited... Updated Balance is {Balance}";
        }

        private void EvaluateState()
        {
            _state = _manager.StateTransition(Balance) ?? _state;
        }

        public string GetBenefits()
        {
            return _state.GetBenefits();
        }

        public StateManager GetManager()
        {
            return _manager;
        }
    }
}
