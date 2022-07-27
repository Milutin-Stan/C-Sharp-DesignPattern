using System;
using System.Collections.Generic;
using Sandwich.factories;

//IMPORTANT USE ARGUMENTS WHILE RUNNING THIS PROGRAM EX: A Sandwich1, C Sandwich1, B Sandwich2
namespace Sandwich
{
    class Program
    {
        static void Main(string[] args)
        {
            SandwitchFactory sandwitchFactory = new SandwitchFactory();
            
            List<Sandwich> sandwiches = sandwitchFactory.create();

            CommandParser commandParser = new CommandParser(args);
            
            CommandFactory commandFactory = new CommandFactory();

            Command command = commandFactory.create(commandParser, sandwiches);

            Console.WriteLine(command.ToString());
        }
    }
}