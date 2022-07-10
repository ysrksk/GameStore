using GameStore.Abstract;
using GameStore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaigns campaigns)
        {
            Console.WriteLine("Kampanya Eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Kampanya Silindi");
        }

        public void Update()
        {
            Console.WriteLine("Kampanya Güncellendi");
        }
    }
}
