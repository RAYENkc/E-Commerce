using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace TP_Ecommerce.Models
{
    public class Categorie
    {
        [Key]
        public int IDCat { get; set; }
        public string NameCat { get; set; }
    }
}