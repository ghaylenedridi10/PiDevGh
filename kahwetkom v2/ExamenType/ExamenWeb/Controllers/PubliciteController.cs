using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Entities;
using System.Net;
using Data;
using ExamenWeb.Models;
using System.IO;
using System.Data.Entity;

namespace ExamenWeb.Controllers
{
    public class PubliciteController : Controller
    {
        private ExamenContext db = new ExamenContext();
        PubliciteService sp = new PubliciteService();
        ProduitService ps = new ProduitService();

       
   

    
        public ActionResult ListePublicitee()
        {
            ExamenContext db = new ExamenContext();

            ////List<Product> listprod = Session["Products"] as List<Product>;
            //var produit = sp.GetMany();

            return View(db.Publicites.ToList());
        }

        [HttpPost]
        public ActionResult ListePublicitee(String SearchString)
        {
            var publicite = sp.GetMany(p => p.Titre.Contains(SearchString));
            return View(publicite);
        }
        // GET: Product/Create
        public ActionResult Create()
        {
            PublicitesModel pm = new PublicitesModel();
            //pour recupérer un  champ spécifique  Select(c=>c.name)

            IEnumerable<Produit> Prods = db.Produits.ToList();
            ViewBag.p = Prods;



            return View(pm);
        }




        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(PublicitesModel pm, HttpPostedFileBase Image,Publicite publicite)
        {
            publicite.Products = db.Produits.Find(Convert.ToInt32(publicite.idProducts));
            
            pm.Image = Image.FileName;
            Publicite p = new Publicite()
            {
                Titre = pm.Titre,

                Products = db.Produits.Find(Convert.ToInt32(publicite.idProducts)),

            Description = pm.Description,
                Image = pm.Image,
                idProducts = pm.idProducts


            };


            var path = Path.Combine(Server.MapPath("~/Content/Upload/"), Image.FileName);
            Image.SaveAs(path);




            try
            {
                // TODO: Add insert logic here
                sp.Add(p);
                // listprod.Add(p);

                // Session["Products"] = listprod;

                sp.Commit();
                return RedirectToAction("ListePublicitee");
            }
            catch
            {
                return View();
            }
        }
        // GET: Produit/Delete/5
        public ActionResult Delete(int id)
        {
            var Publicite = sp.GetById(id);
            return View(Publicite);
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var p = sp.GetById(id);
            try
            {
                // TODO: Add delete logic here

                sp.Delete(p);
                sp.Commit();


                return RedirectToAction("ListePublicitee");
            }
            catch
            {
                return View();
            }
        }
        // POST: User/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Publicite u = sp.GetById((int)id);
            if (u == null)
            {
                return HttpNotFound();
            }
            return View(u);
        }

        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdPublicite,Image,Titre,Description")] Publicite offre)
        {
            if (ModelState.IsValid)
            {
                db.Entry(offre).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ListePublicitee");
            }
            return View(offre);
        }

        public ActionResult Search()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Search(String SearchTitre)
        {
            var result = db.Publicites.Where(a => a.Titre.Contains(SearchTitre) ).ToList();
            return View(result);
        }



    }
}
