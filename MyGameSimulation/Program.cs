using MyGameSimulation.Abstract;
using MyGameSimulation.Adapters;
using MyGameSimulation.Concrete;
using MyGameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            gamer.gamerBirthDate = new DateTime(1996, 9, 1);
            gamer.gamerFirstName = "Bekir";
            gamer.gamerLastName = "ATLI";
            gamer.gamerTcNo = "123456";
            gamer.gamerNickName = "BlackEagle";
            gamer.gamerId = 1221;

            Game game1 = new Game();
            game1.Id = 1;
            game1.GameName = "GTA V";
            game1.GameAbout = "Multi Player Game";

            Campaign campaign1 = new Campaign();
            campaign1.Id = 321;
            campaign1.CampaignName = "Isıtan Mart";
            campaign1.Abaout = "Çeşit çeşit üründe büyük indirimler";

            BaseGamerManager gamerManager = new GamerManager(new GamerCheckManager());
            gamerManager.Add(gamer);

            IGameService game = new GameManager();
            game.Add(game1);
            Console.WriteLine("-----------------------------------------------");

            ICampaignService campaign = new CampaignManager();
            campaign.Add(campaign1);
            Console.WriteLine("-----------------------------------------------");

            IOrderService orderService = new OrderManager();
            orderService.Order(gamer, campaign1, game1);


            Console.ReadKey();
        }
    }
}
