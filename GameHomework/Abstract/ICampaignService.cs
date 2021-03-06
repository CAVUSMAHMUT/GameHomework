using GameHomework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Deleted(Campaign campaign);
    }
}
