using MyGameSimulation.Abstract;
using MyGameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameSimulation.Concrete
{
    public class GamerManager : BaseGamerManager
    {
        private IGamerValidationService _gamerValidationService;

        public GamerManager(IGamerValidationService gamerValidationService)
        {
            _gamerValidationService = gamerValidationService;
        }

        public override void Add(Gamer gamer)
        {
            if (_gamerValidationService.CheckIfRealGamer(gamer))
            {
                base.Add(gamer);
            }
            else
            {
                throw new Exception("Kimlik bilgileri doğru değil");
            }
        }
    }
}
