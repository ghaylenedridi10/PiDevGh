using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Categorie
    {
        [Key]
        public int Id_categorie { get; set; }
        public string Nom { get; set; }
        public virtual ICollection<Produit> Produits_C { get; set; }

       

        //categories :
        //Téléphones, Clés, Puces, ADSL, Fibre 
    }
}
