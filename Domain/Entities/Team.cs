using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Team
    {
        public int IdTeam;
        public String NomTeam;
        //id president
        // list id organisateur
        //id event
        ICollection<Evenement> EventTeam { get; set; }
        ICollection<User> Organizers { get; set; }
         public User President { get; set; } 



    }
}
