using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TP_Ecommerce.DAL;
using TP_Ecommerce.Models;
namespace TP_Ecommerce.Controllers
{
    public class ProduitController : Controller
    {
        private EcommerceContext db = new EcommerceContext();
        public ActionResult Index()
        {
            var produits = db.Produits.Include(p =>
            p.Categorie).Include(p => p.Marque);
            return View(produits.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.CategorieID = new SelectList(db.categories, "IDCat",
            "NameCat");
            ViewBag.MarqueID = new SelectList(db.Marques, "IDMrq",
            "NameMrq");
            return View();
        }
        [HttpPost]
        public ActionResult Create([Bind(Include ="ID,CategorieID,MarqueID,ProductName,Price,qte")] produit produit)
        {
            if (ModelState.IsValid)
            {
                db.Produits.Add(produit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategorieID = new SelectList(db.categories, "IDCat",
            "NameCat", produit.CategorieID);
            ViewBag.MarqueID = new SelectList(db.Marques, "IDMrq",
            "NameMrq", produit.MarqueID);
            return View(produit);
        }
    }
}