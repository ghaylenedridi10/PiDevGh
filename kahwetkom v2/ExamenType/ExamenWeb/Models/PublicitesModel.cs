using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenWeb.Models
{
    public class PublicitesModel
    {
        public string Image { get; set; }
        public string Description { get; set; }
        public string Titre { get; set; }
        [NotMapped]
        public string idProducts { get; set; }
        public Produit Products { get; set; }
        public Produit Produit { get; set; }
    }
}