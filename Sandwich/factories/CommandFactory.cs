using System.Collections.Generic;
using Sandwich.interfaces;

namespace Sandwich.factories
{
    public class CommandFactory
    {
        public Command createCommand(Parser parser, List<Sandwich> sandwiches)
        {
            Command command = new Command(parser.Parse(sandwiches));
            return command;
        }
    }
}