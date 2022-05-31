using System;
using System.Collections.Generic;

namespace Sandwich
{
    public class Sandwich
    {
        public string Name;
        public List<String> Ingredients;
        public double Prix;
        
        public Sandwich(string name,List<String> ingredients, double prix)
        {
            Name = name;
            Ingredients = ingredients;
            Prix = prix;
        }

        public override string ToString()
        {
            String retrour = "  Ingredients \n";
                for (int i = 0; i < this.Ingredients.Count; i++)
                {
                    retrour += "            " + Ingredients[i] + "\n";
                }

                return retrour;
        }
    }
}