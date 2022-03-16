using MyGameSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameSimulation.Entities
{
    public class Gamer : IEntity
    {
        public int gamerId { get; set; }
        public string gamerTcNo { get; set; }
        public string gamerNickName { get; set; }
        public string gamerFirstName { get; set; }
        public string gamerLastName { get; set; }
        public DateTime gamerBirthDate { get; set; }
    }
}
