using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Boutique
    {
        [Key]
        public int Id_boutique { get; set; }
        public string Nom { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        // public string adresse { get; set; }
        public string Ville { get; set; } //liste deroulante 
        public string Zone { get; set; }
        public string Service { get; set; }
        public string Heure_ouverture { get; set; }
        public string Heure_fermeture { get; set; }
        public float Ascisse_X { get; set; }
        public float Ordonné_Y { get; set; }


        public virtual ICollection<Produit> Produits_B { get; set; }


    }
}
