using System;
using System.Collections.Generic;
//student id 104817068
namespace HelloWorld
{
    class Program
    {
        public static void Main(String[] args)
        {
            Message myMesssage = new Message("Hello, World! - from Message Object");
            myMesssage.Print();

            Message[] messages = {
                 //first greeting to message
                new Message("Welcome back bro"),
                 //second greeting to message
                new Message("Great name"),
                //third greeting to message
                new Message("oh HI!"),
                //fourth greeting to message
                new Message("What a lovely name"),
                //standard greeting to message
                new Message("Welcome! Nice to meet you")
                    };

            

            //testing the name to return message


            while (true)
            {
                //input user name
                Console.WriteLine("Enter your name(type 'exit' or 'quit' to end)");
                string name = Console.ReadLine();

                //if the user press enters
                if(string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("enter a valid name");
                }
                else if (name.ToLower() == "exit" || name.ToLower() == "quit")
                {
                    break; // exit the loop if the user enters 'exit' or 'quit'
                }
                else if (name.ToLower() == "sar")
                {
                    messages[0].Print();
                }
                else if (name.ToLower() == "kyle")
                {
                    messages[1].Print();
                }
                else if (name.ToLower() == "hank")
                {
                    messages[2].Print();
                }
                else if (name.ToLower() == "peter")
                {
                    messages[3].Print();
                }
                else
                {
                    messages[4].Print();
                }
            }
        }
    }
}