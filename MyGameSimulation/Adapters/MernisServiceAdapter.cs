using MyGameSimulation.Abstract;
using MyGameSimulation.Entities;
using MyGameSimulation.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameSimulation.Adapters
{
    public class MernisServiceAdapter : IGamerValidationService
    {
        public bool CheckIfRealGamer(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(gamer.gamerTcNo), gamer.gamerFirstName.ToUpper(), gamer.gamerLastName.ToUpper(), gamer.gamerBirthDate.Year);
        }
    }
}
