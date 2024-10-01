using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_ClaudeMael_ACT2_3.Objets
{
    internal class SandwichMaker
    {

        private string[] _proteines = { "jambon", "fromage", "roast beef", "salami" };
        private string[] _condiments = { "ketchup", "mayonnaise", "moutarde", "sel/poivre" };
        private string[] _pains = { "complet", "blanc", "baguette", "seigle" };
        private string[] _crudites = { "salade", "carotte", "concombre", "radis" };
        public SandwichMaker()
        {

        }

        public string composeSandwich()
        {
            Random random = new Random();
            return "Voici votre sandwich : " + _pains[random.Next(0, _pains.Length)] + ", " + _proteines[random.Next(0, _proteines.Length)] + ", " + _crudites[random.Next(0, _crudites.Length)] + ", " + _condiments[random.Next(0, _condiments.Length)];
        }

    }
}
