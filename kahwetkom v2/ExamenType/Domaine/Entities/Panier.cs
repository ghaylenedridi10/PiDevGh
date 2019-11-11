using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Panier
    {
        [Key]
        public int IdPanier { get; set; }
        public virtual User Userr { get; set; }
        public int? IdUser { get; set; }
        public virtual ICollection<Produit> Products { get; set; }
        public int? IdProduit { get; set; }
        public int Quantite { get; set; }
        
    }
}
