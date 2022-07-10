using GameStore.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Entity
{
    public class Campaigns:IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public double Discount { get; set; }
    }
}
