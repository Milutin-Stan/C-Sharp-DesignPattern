using System;
using System.Collections.Generic;

namespace Sandwich
{
    public class Command
    {
        public List<Sandwich> _sandwichClasses;
        public double PrixTotal;

        public Command(List<Sandwich> sandwichClasses)
        {
            _sandwichClasses = sandwichClasses;
            for (int i = 0; i < sandwichClasses.Count; i++)
            {
                PrixTotal += sandwichClasses[i].Prix;
            }
        }

        public Command()
        {
            
        }

        public override string ToString()
        {
            String retour = "";
            for (int i = 0; i < _sandwichClasses.Count; i++)
            {
                retour += ($"Sandwich{i+1} \n");
                retour += _sandwichClasses[i].ToString();
            }

            return retour += $"PrixTotal : {PrixTotal}";
        }
    }
}