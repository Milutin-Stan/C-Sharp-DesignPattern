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
            
            List<Sandwich> sandwiches = sandwitchFactory.createSandwitches();

            CommandParser commandParser = new CommandParser(args);
            
            CommandFactory commandFactory = new CommandFactory();

            Command command = commandFactory.createCommand(commandParser, sandwiches);

            Console.WriteLine(command.ToString());
        }
    }
}