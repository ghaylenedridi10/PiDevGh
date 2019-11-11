using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Produit
    {
        [Key]
        public int Id_produit { get; set; }
        [NotMapped]
        public int IdProduit { get {return Id_produit; }  }
        //  public string categorie { get; set; }
        public string Libelle { get; set; }
        public string Nom { get; set; }
        public int Quantitee { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public virtual ICollection<Packs> ListPack { get; set; }
        public int? IdPack { get; set; }





        [ForeignKey("Id_categorie")]
        public virtual Categorie Categories { get; set; }
      //  [ForeignKey("Category")]
        public int? Id_categorie { get; set; }

        [ForeignKey("Id_boutique")]
        public virtual Boutique Boutiques { get; set; }
       // [ForeignKey("Category")]
        public int? Id_boutique { get; set; }

        [ForeignKey("Id_fichemobile")]
        public virtual FicheTechnique_Mobile FicheTechniques { get; set; }
        // [ForeignKey("Category")]
        public int? Id_fichemobile { get; set; }


    }
}
