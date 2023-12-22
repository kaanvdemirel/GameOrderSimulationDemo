using GameOrderSimulationDemo.Entities;
using GameOrderSimulationDemo.Managers;
using GameOrderSimulationDemo.Services;

Campaign campaign1 = new Campaign();

campaign1.CampaignName = "New year campaign";
campaign1.DiscountRate = 20;

Campaign campaign2 = new Campaign();
campaign2.CampaignName = "Black Friday";
campaign2.DiscountRate = 40;


Games game1 = new Games();
game1.GameName = "Grand Theft Auto";
game1.GamePrice = 2000;
game1.UnitsİnStock = 100;
game1.Campaign = campaign2;

Games game2 = new Games();

game2.GameName = "Call of Duty";
game2.GamePrice = 1000;
game2.UnitsİnStock = 50;


Gamer gamer1= new Gamer();

gamer1.GamerName = "Kaan";
gamer1.GamerSurname = "Demirel";
gamer1.TcNo = "10940240491";
gamer1.DateOfBirth = new DateTime(2002);

Gamer gamer2 = new Gamer();
gamer2.GamerName = "Yusuf";
gamer2.GamerSurname = "Sağaltıcı";
gamer2.TcNo = "63670154490";
gamer2.DateOfBirth = new DateTime(2001);


IGameOrderService gameOrderManager = new GameOrderManager();


gameOrderManager.Sell(gamer1, game1);
gameOrderManager.Sell(gamer2, game2);







