using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocOnStateDesignPattern.States
{
    // To Avoid OCP Implemented the Seperate StateManager
    // Please Read the StateTransition()
    internal class StateManager
    {
       private List<State> _States;
       public StateManager() 
       {
            _States = new List<State>
            {
                new BasicState(),
                new SilverState(),
                new GoldState(),
                new PlatinumState(),
            };
       }    
       
       double GetMaxBalance()
       {
            double maxBalance = 0;
            foreach (var state in _States)
            maxBalance = maxBalance > state.MaxBalance ? maxBalance : state.MaxBalance;
            return maxBalance;
       }
       public string AddState(State state)
       {
            if (state != null)
            {
                _States.Add(state);
                return $"State Added Successfully";
            }
            return $"Please Pass Not Null State Object!";
       }
       
       /* This Function and This Class is Very Important To Avoid OCP as well as Maintain Accuracy...
        * WHY....?
        * Problem : If I used Foreach Loop For single time then it can lead an following issue.
        *          I. Assumed that we have 2 State 1. Silver State => Range is 0 - 9999 Rs.
        *                                          2. Gold State   => Range is 10000 - 19999 Rs.
        *                                                 
        *         II. If Initial Balance is 5000 Then StateTransition Will Assigned Silver State
        *             This is Perfectly Fine ok :)
        *                     
        *        III. But If Our Balance is Jumped From 5000 to 25000 so new Balance is 25000 Rs
        *             In this Scenario Our Single Foreach Loop will Return NUll State and In Account
        *             Context if The manager.StateTransition(balance) Function returns NUll then 
        *             We will Assigned Account.State = CurrentState Means Again Silver State will Assigned..
        * 
        * Solution : I used Foreach Loop Twice to Avoid InAccuracy of Trasitions Between the states...
        *            Lets Assumed Above Scenario...
        *            We Jumped From 5000 to 25000 ==> I used _maxBalance Variable Which Helps tp Assigned
        *            Highes Category of Membership to Account Holder Having Balance Greater than _maxBalance
        *            Which Will Maintain The Accuracy of Program.
        *            
        * Disclaimer : This is Just My Thought of Understanding Using Simple Concepts But We can used More
        *              Flexible Approaches to Resolve OCP in Exception Cases with Accuracy :) Thank You!     */            
 
       
       public State StateTransition(double balance)
       {  
          foreach (var state in _States)
            if(balance >= state.MinBalance && balance <= state.MaxBalance)
              return state;
          double maxBalance = GetMaxBalance();
          foreach (var state in _States)
             if(maxBalance == state.MaxBalance)
                    return state;
            return null;        
       }  
    }
}
