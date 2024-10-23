using PocOnStateDesignPattern.Context;
using PocOnStateDesignPattern.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PocOnStateDesignPattern.Presentation
{
    internal class ApplicationUI
    {
        public static void StartApplication()
        {
            Account account = new Account(899947, "Shyam Kumavat", 4000);

            Console.WriteLine("\n"+account.GetBenefits());

            account.DepositMoney(2000);
            Console.WriteLine("\n" + account.GetBenefits());

            // Jumped From Silver to Platinum....

            account.DepositMoney(50000);
            Console.WriteLine("\n" + account.GetBenefits());

            // Switch To Gold State....

            account.WithDrawMoney(40000);
            Console.WriteLine("\n" + account.GetBenefits());

            // Adding New State Without Affecting the Existing States.... and OCP Violation The Code is Commented.
            // Create DiamondState : State Using Abstract Class. Then Add it to States Which is Managed By State Manager

            //StateManager manager =  account.GetManager();

            //manager.AddState(State new DiamondState);
        }
    }
}
