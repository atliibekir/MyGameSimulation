using MyGameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameSimulation.Abstract
{
    public abstract class BaseGamerManager : IGamerService
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine("{0} {1}, Kayıt işleminiz başarı ile tamamlandı.", gamer.gamerFirstName, gamer.gamerLastName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Başarı ile güncellendi.");
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Başarı ile silindi!");
        }
    }
}
