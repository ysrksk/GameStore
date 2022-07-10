using GameStore.Abstract;
using GameStore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Concrete
{
    public class GamerManager : IGamerService
    {
        private IGamerCheckService _gamerCheckService;
        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public void Add(Gamer gamer)
        {
            if(_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("Saved to db : " + gamer.FirstName);
            }
            else
            {
                throw new Exception("Not a valid Person");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Güncellendi");
        }
    }
}
