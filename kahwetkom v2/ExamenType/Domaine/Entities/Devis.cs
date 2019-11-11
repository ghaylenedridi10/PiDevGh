using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Devis
    {
        [Key]
        public int IdDevis { get; set; }
        public virtual Panier Panierr { get; set; }
        public int? IdPanier { get; set; }
        public virtual User Users { get; set; }
        public int? IdUser { get; set; }
        public float PrixTotal { get; set; }
        public DateTime DateCommande { get; set; }
        public String Status { get; set; }
        public String Description { get; set; }
    }
}
