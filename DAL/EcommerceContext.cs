using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TP_Ecommerce.Models;



namespace TP_Ecommerce.DAL
{
    public class EcommerceContext :  DbContext 
        
       
    {

        public EcommerceContext() : base("EcommerceContext")
        { }
        public DbSet<Categorie> categories { get; set; }
        public DbSet<Marque> Marques { get; set; }
        public DbSet<produit> Produits { get; set; }

    }

  

}