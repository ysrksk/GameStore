using GameStore.Abstract;
using GameStore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;
        }
    }
}
