using GameStore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Abstract
{
    public interface ISaleService
    {
        void Sale(Gamer gamer, Campaigns campaigns, Game game);
    }
}
