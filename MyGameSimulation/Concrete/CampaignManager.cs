using MyGameSimulation.Abstract;
using MyGameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameSimulation.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya başarıyla eklenmiştir : " + campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya başarıyla silinmiştir!");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya başarıyla güncellenmiştir!");
        }
    }

}
