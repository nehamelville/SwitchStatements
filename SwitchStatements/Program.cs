using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your favorite school subject ? ");
            var favSubject =( Console.ReadLine()).ToLower();

             switch(favSubject)
            {
                case "math":

                        Console.WriteLine($" {favSubject} is my favorite subject!!");
                        break;

                case "english":

                        Console.WriteLine($" {favSubject} is  my favorite subject!!");
                        break;
                
                case "science":

                       Console.WriteLine($" {favSubject} is  my favorite subject!!");
                       break;
                    
                case "social science":

                        Console.WriteLine($" {favSubject} is  my favorite subject!!");
                        break;
                    
                case "politics":

                        Console.WriteLine($" {favSubject} is  my favorite subject!!");
                        break;

                default :

                        Console.WriteLine($"case not handled!!");
                        break;
        

            }

        }
    }
}
