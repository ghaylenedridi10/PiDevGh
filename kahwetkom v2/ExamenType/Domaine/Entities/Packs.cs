using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Packs
    {
        [Key]
        public int IdPack { get; set; }
        public virtual ICollection<Produit> ListProducts { get; set; }
        public int? IdProduit { get; set; }
        public String Image { get; set; }
        public String Titre { get; set; }
        public String Description { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public float Prix { get; set; }
    }
}
