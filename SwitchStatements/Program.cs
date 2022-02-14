using System;

namespace SwitchStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your favorite subject in school?: ");
            var favSubject = Console.ReadLine();
            

            switch(favSubject)
            {
                case "computer Science":
                    Console.WriteLine("Computer Science is super hard! ");
                    break;
                case "math":
                    Console.WriteLine("You can really go places with math. ");
                    break;
                case "english":
                    Console.WriteLine("English was always my least favorite subject ");
                    break;
                case "history":
                    Console.WriteLine("I have come to really like history in the past few years. ");
                    break;
                case "science":
                    Console.WriteLine("Science is the best!! ");
                    break;
                default:
                    Console.WriteLine("I don't know that subject. ");
                    break;
            }
        }
    }
}
