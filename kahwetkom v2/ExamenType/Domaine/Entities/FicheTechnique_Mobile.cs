using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class FicheTechnique_Mobile
    {
        [Key]
        public int Id_fichemobile { get; set; }
        public string Marque { get; set; }
        public string Dimensions { get; set; }
        public float Poids { get; set; }
        public string Ecrant { get; set; }
        public string Definition { get; set; }
        public string Photo { get; set; }
        public string Os { get; set; }
        public string Memoire_interne { get; set; }
        public string Micro_sd { get; set; }
        public string Connectivite { get; set; }
        public string Nfc { get; set; }
        public string Soc { get; set; }
        public string Ram { get; set; }
        public string Capteur_enpreintes { get; set; }
        public string Resistance_eau { get; set; }
        public int Batterie { get; set; }
        public string Port_charge { get; set; }
        public string Recharge_rapide { get; set; }
        public string Recharge_sansfil { get; set; }
        public string Coloris { get; set; }
        public float Prix { get; set; }


       


    }
}
