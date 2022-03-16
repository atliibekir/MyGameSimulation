using MyGameSimulation.Abstract;
using MyGameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameSimulation.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun eklendi : " + game.GameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun silindi : " + game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun güncellendi : " + game.GameName);
        }
    }
}
