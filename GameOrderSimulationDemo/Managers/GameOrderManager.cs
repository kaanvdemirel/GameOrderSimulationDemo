using GameOrderSimulationDemo.Entities;
using GameOrderSimulationDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOrderSimulationDemo.Managers
{
    internal class GameOrderManager : IGameOrderService
    {
        public void Sell(Gamer gamer, Games game)
        {
            if (game.Campaign!=null)
            {
                double gamePrice = (game.GamePrice * game.Campaign.DiscountRate) / 100;
                game.GamePrice = game.GamePrice - gamePrice;
                Console.WriteLine(gamer.GamerName + " " + gamer.GamerSurname + " " +  "named gamer" + " " + game.GameName + " Purchased" +
                    " the game at a discounted price.");





            }
            else
            {
                Console.WriteLine(gamer.GamerName + " " + gamer.GamerSurname + " " +  "named gamer " +" " +  game.GameName + " Purchased the game." );
            }
        }
    }
}
