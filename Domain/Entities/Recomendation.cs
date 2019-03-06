using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{


    //classe porteuse de données
    [Table("Recommendtaion")]
    public class Recomendation
    {
        public int IdRecom;
        // id particpant
        //id evenment
        public String MailRecomd;
        public enum EtatRecom { valide, notvalide,inprogress }
       
       
    
            [Key, Column(Order = 0)]
            public int EventId { get; set; }
            [Key, Column(Order = 1)]
            public int UserId { get; set; }
            [Key, Column(Order = 2)]
           
            public Evenement Events { get; set; }
            public User Participants { get; set; }
        }
}
