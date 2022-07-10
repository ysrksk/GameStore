using GameStore.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Entity
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public double Price { get; set; }

        public virtual List<Gamer> Gamers { get; set; }
    }
}
