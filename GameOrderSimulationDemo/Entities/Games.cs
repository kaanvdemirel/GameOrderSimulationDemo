using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOrderSimulationDemo.Entities
{
    internal class Games
    {
        public string GameName { get; set; }

        public double GamePrice { get; set; }
        public int UnitsİnStock { get; set; }
        public Campaign Campaign { get; set; }


    }
}
