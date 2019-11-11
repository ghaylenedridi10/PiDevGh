using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Commande
    {
        [Key]
        public int IdCommande { get; set; }
        public virtual Panier Panierr { get; set; }
        public int IdPanier { get; set; }
        public virtual User Users { get; set; }
        public int IdUser { get; set; }
        public float PrixTotal { get; set; }
        public DateTime DateCommand { get; set; }

    }
}
