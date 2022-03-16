using MyGameSimulation.Abstract;
using MyGameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameSimulation.Concrete
{
    public class GamerCheckManager : IGamerValidationService
    {
        public bool CheckIfRealGamer(Gamer gamer)
        {
            if (gamer.gamerBirthDate == new DateTime(1996, 9, 1) && gamer.gamerFirstName == "Bekir" && gamer.gamerLastName == "ATLI" && gamer.gamerTcNo == "123456")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
