using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Promotion
    {
        [Key]
        public int IdPromotion { get; set; }
        public virtual Produit Products { get; set; }
        public int IdProduit { get; set; }
        public float NewPrice { get; set; }
        public float Remise { get; set; }
        public DateTime DateFin { get; set; }
    }
}
