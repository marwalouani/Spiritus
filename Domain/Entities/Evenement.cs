﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
   public class Evenement
    {
        public  int IdEvent;
        public String NomEvent;
        public DateTime DateEventDebut;
        public DateTime DateEventFin;
        public String LocationEvent;
        public String DescriptionEvent;
        public int NbPlaceEvent;
        [DataType(DataType.ImageUrl), Required(ErrorMessage = "la proprieté image est obligatoire")]
        public String ImageEvent;
        public enum Methodepaiement { Online, BoxOffice }
        public ICollection<Ticket> Tickets { get; set; }
        public Team Team { get; set; }
        public ICollection<Feedback> Feedbacks { get; set; }
    }
}
