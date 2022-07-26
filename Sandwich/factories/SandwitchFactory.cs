using System;
using System.Collections.Generic;

namespace Sandwich.factories
{
    public class SandwitchFactory
    {
        public List<Sandwich> createSandwitches()
        {
            List<String> newIngredientsA = new List<string>() {"Beure", "Sel", "Fromage", "Porc"};
            List<String> newIngredientsB = new List<string>() {"Beure", "Sel", "Fromage", "Poulet"};
            List<String> newIngredientsC = new List<string>() {"Beure", "Sel", "Fromage", "Boeuf"};

            Sandwich sandwich1 = new Sandwich("Sandwich1", newIngredientsA, 5.5);
            Sandwich sandwich2 = new Sandwich("Sandwich2", newIngredientsB, 6.5);
            Sandwich sandwich3 = new Sandwich("Sandwich3", newIngredientsC, 10.5);

            List<Sandwich> sandwiches = new List<Sandwich>();
            sandwiches.Add(sandwich1);
            sandwiches.Add(sandwich2);
            sandwiches.Add(sandwich3);

            return sandwiches;
        }
    }
}