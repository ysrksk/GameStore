using GameStore.Concrete;
using GameStore.Entity;
using System;

namespace GameStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer()
            {
                Id = 1,
                FirstName = "Ela",
                LastName = "Kırmızı",
                NationalityId = "12345679811",
                BirthDAy = DateTime.Parse("28/05/1989")
            };
            GamerManager gamerManager= new GamerManager(new GamerCheckManager());

            gamerManager.Add(gamer1);

            Game game1 = new Game()
            {
                Id = 1,
                GameName = "Fly",
                Price = 25
            };

            Campaigns campaign1 = new Campaigns()
            {
                Id = 1,
                CampaignName = "Black Friday",
                Discount = 50
            };

            CampaignManager tempCampaign = new CampaignManager();

            tempCampaign.Add(campaign1);

            SaleManager saleManager = new SaleManager();

            saleManager.Sale(gamer1, campaign1, game1);

        }
    }
}
