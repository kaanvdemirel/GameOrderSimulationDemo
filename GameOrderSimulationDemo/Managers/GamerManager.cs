using GameOrderSimulationDemo.Entities;
using GameOrderSimulationDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOrderSimulationDemo.Managers
{
    internal class GamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Gamer added.");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer deleted.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer updated.");
        }
    }
}
