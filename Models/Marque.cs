using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TP_Ecommerce.Models
{
    public class Marque
    {
        [Key]
        public int IDMrq { get; set; }
        public string NameMrq { get; set; }
    }
}