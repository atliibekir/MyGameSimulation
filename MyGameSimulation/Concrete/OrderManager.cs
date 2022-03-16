using MyGameSimulation.Abstract;
using MyGameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameSimulation.Concrete
{
    public class OrderManager : IOrderService
    {
        public void Order(Gamer gamer, Campaign campaing, Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun " + campaing.CampaignName + " indirmi dahilinde satın aldınız.");
            Console.WriteLine("Satın alan kişi : " + gamer.gamerFirstName + " " + gamer.gamerLastName);
        }
    }
}
