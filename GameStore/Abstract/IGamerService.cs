using GameStore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Abstract
{
    public interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
