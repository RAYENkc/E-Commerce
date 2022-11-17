using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TP_Ecommerce.Models
{
    public class produit
    {
        [Key]
        public int ID { get; set; }
        public int CategorieID { get; set; }

        public int MarqueID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int qte { get; set; }
        [ForeignKey("CategorieID")]
        public Categorie Categorie { get; set; }
        [ForeignKey("MarqueID")]
        public Marque Marque { get; set; }
    }
}