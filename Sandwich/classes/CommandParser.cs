using System.Collections.Generic;
using System.Linq;
using Sandwich.interfaces;

namespace Sandwich
{
    public class CommandParser: Parser
    {
        public string[] args;
        public Dictionary<string, string> entry;

        public CommandParser(string[] _args)
        {       
            args = _args;
            entry = new Dictionary<string, string>();
        }

        public List<Sandwich> Parse(List<Sandwich> sandwiches)
        {
            for (int i = 0; i < args.Length; i+=2)
            {
                entry[args[i]] = args[i + 1].Replace(",","");
            }

            var orderedEntry = entry.OrderBy(item => item.Key);

            List<Sandwich> sandwichClasses = new List<Sandwich>();

            foreach (var command in orderedEntry)
            {
                foreach (var sandwich in sandwiches)
                {
                    if (command.Value == sandwich.Name)
                    {
                        sandwichClasses.Add(sandwich);
                    }
                }
            }

            return sandwichClasses;
        }
    }
}