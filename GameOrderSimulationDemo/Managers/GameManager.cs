using GameOrderSimulationDemo.Entities;
using GameOrderSimulationDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOrderSimulationDemo.Managers
{
    internal class GameManager : IGameService
    {
        public void Add(Games game)
        {
            Console.WriteLine("Game added.");
        }

        public void Remove(Games game)
        {
            Console.WriteLine("Game removed");
        }

        public void Update(Games game)
        {
            Console.WriteLine("Game updated.");
        }
    }
}
