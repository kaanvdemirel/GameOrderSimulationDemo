using GameOrderSimulationDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOrderSimulationDemo.Services
{
    internal interface ICampaignService
    {
        void Add(Campaign campaign);
        void Remove(Campaign campaign); 
        
    }
}
