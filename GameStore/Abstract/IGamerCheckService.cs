using GameStore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Abstract
{
    public interface IGamerCheckService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
