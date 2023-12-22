using GameOrderSimulationDemo.Entities;
using GameOrderSimulationDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOrderSimulationDemo.Managers
{
    internal class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign added.");
        }

        public void Remove(Campaign campaign)
        {
            Console.WriteLine("Campaign removed");
        }
    }
}
