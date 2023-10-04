using ObserverApp.Observer;
using ObserverApp.Subject;

namespace ObserverApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a concrete subject
            ConcreteSubject subject = new ConcreteSubject();

            // Create concrete observers
            ConcreteObserver observer1 = new ConcreteObserver(" Akash");
            ConcreteObserver observer2 = new ConcreteObserver("Amal");
            ConcreteObserver observer3 = new ConcreteObserver("Mivin");
            ConcreteObserver observer4 = new ConcreteObserver("Albin");
            ConcreteObserver observer5 = new ConcreteObserver("Teena");
            ConcreteObserver observer6 = new ConcreteObserver("Aswin");
            ConcreteObserver observer7 = new ConcreteObserver("Abhi");

            // Register observers with the subject
            subject.RegisterObserver(observer1);
            subject.RegisterObserver(observer2);
            subject.RegisterObserver(observer3);
            subject.RegisterObserver(observer4);

            subject.RegisterObserver(observer5);
            subject.RegisterObserver(observer6);
            subject.RegisterObserver(observer7);

            // Set a message on the subject, which will notify the observers
            subject.SetMessage("Hello, Observers!");

            // Remove an observer
            subject.RemoveObserver(observer1);



            //Console.WriteLine("Select a message type (1 for Important, 2 for Normal):");
            //string userInput = Console.ReadLine();

            //string message = "";

            // Use switch case to set the message based on user input
            //switch (userInput)
            //{
            //    case "1":
            //        message = "Important";
            //        break;
            //    case "2":
            //        message = "Normal";
            //        break;
            //    default:
            //        Console.WriteLine("Invalid choice. Using default message.");
            //        message = "Default";
            //        break;
            //}

            // Set another message on the subject
            subject.SetMessage("this is new msg for all other observers");

            Console.ReadLine();
        }
    }
}