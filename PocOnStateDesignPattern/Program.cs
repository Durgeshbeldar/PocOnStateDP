using PocOnStateDesignPattern.Presentation;

namespace PocOnStateDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Following Method Starts the Application ...

            ApplicationUI.StartApplication(); 

            /************************** POC ON STATE DESIGN PATTERN ************************************
             * 
             * Explaination : The State Design Pattern Allows An Object to Change Its Behavior When
             *                its Internal State Changes.
             *                
             *                Some Important Terms in State Design Patterns Are : 
             *                Context, State Interface and Concrete States.
             *                
             *                Context : The main class that holds a reference to the current state
             *                State Interface : Defines the common behavior that all concrete states must implement.
             *                Concrete States: These are specific states that implement the state interface
             *                and define behavior based on the current state.
             *                
             * Examples : There are Some Popular Examples Are :
             *            I. ECommerce Website Has Different States To Process and Maintain Order Status.
             *           II. ATM Machine, Traffic Light System, Vending Machines etc etc... 
             * 
             * Implemented Example :
             *             In this POC I have Implemented an Example of Context Bank Account Who Represent OR
             *             Delivered Different Benefits to User When The Balance Which is an Internal Property
             *             of Account Class Changes. It Dynamically Assigned the Different States as the 
             *             Dynamic Variable Balance is Changes When an Some Interaction Done By User.
             *             
             *             This is an Exceptional Example As Well Because if We Assigned the States Based on
             *             Decision Making Statements (if-else-if ladder) Which Making States Tightly Coupeled
             *             with Context Account Class Which will lead OCP Violation in Future When We Will Add
             *             New States. 
             *             
             *             ** IMPORTANT POINT : To Avoid OCP and Maintain Accuracy I Did Not Used Interfaces Directly
             *             Instead of that I Used Abstract Class So That States can Have Min and Max Balance Properties
             *             To Define the Ranges to states to determine the Which New Changed State We Can Assigned to Account.
             *             
             *             For Smooth Implementation I Used Seperate Class StateManager Who Manages The States and Allowing us
             *             to Add New States Without Affecting the Existing State. and Maintain Accuracy and OCP Principle.
             *             
             *             All Information Regarding StateTransition() Function is Mentined in StateManager Class.
             *                
             * Advantages : 1. Simplified The Code. 2. Easier Maintainance (Ex. Add New States) 3. Encapsulated State Behaviour.
             * 
             * DisAdvantages : 1. Increased Number of Classes 2. In Some Cases It is Hard To Implement and Maintain...
             * 
             */

        }
    }
}
