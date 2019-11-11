using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
   public class Publicite
    {
        [Key]
        public int IdPublicite { get; set; }
        public String Image { get; set; }
        public String Titre { get; set; }
        public String Description { get; set; }
        [NotMapped]
        public string idProducts { get; set; }
        public Produit Products { get; set; }
        public Produit Produit { get; set; }


    }
}
