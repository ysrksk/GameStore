using GameStore.Abstract;
using GameStore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Concrete
{
    public class SaleManager : ISaleService
    {
        public void Sale(Gamer gamer, Campaigns campaigns, Game game)
        {
            Console.WriteLine( "{0} isimli oyuncu {1} kampanyasından faydalanarak {2} adlı oyunu {}TL ya satın almıştır.", gamer.FirstName, campaigns.CampaignName, game.GameName, game.Price);
        }
    }
}
