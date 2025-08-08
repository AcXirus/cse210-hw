using System;
using System.Security.Cryptography.X509Certificates;


/// Eternal Quest - Goal Tracking Program
/// -------------------------------------
/// This console app uses OOP principles:
/// - Inheritance: All goals inherit from 'Goal' base class
/// - Polymorphism: GoalManager handles all goals generically
/// - Abstraction: Shared logic abstracted in base class
/// - Encapsulation: Each goal type manages its own data
///
/// Extra Features:
/// - File save/load system
/// - Bonus points in checklist goals
/// - Easily extendable with new goal types
/// - Interactive, menu-based interface

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}