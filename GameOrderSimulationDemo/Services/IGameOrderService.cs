using GameOrderSimulationDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOrderSimulationDemo.Services
{
    internal interface IGameOrderService
    {

        void Sell(Gamer gamer, Games game);
    }
}
