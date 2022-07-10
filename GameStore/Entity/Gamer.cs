using GameStore.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Entity
{
    public class Gamer:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public DateTime BirthDAy { get; set; }

        public virtual Game Game { get; set; }
    }
}
