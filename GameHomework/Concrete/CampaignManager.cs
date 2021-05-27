using GameHomework.Abstract;
using GameHomework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Yeni Kampanyalar Eklendi: "+campaign.CampaignName);
        }

        public void Deleted(Campaign campaign)
        {
            Console.WriteLine("Kampanya Kaldırıldı: "+campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanyalar Yenilendi: "+campaign.CampaignName);
        }
    }
}
