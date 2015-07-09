using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NoticiasDISC.Contexto;
using NoticiasDISC.Models;

namespace NoticiasDISC.Controllers
{

    public class NoticiaController : Controller
    {
        private NoticiasContext db = new NoticiasContext();

        // GET: Noticia 
        public ActionResult Index()
        {
            var noticias = db.Noticias.Include(n => n.Autor);
            return View(noticias.ToList());
        }

        // GET: Noticia/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Noticia noticia = db.Noticias.Find(id);
            if (noticia == null)
            {
                return HttpNotFound();
            }
            return View(noticia);
        }

        // GET: Noticia/Create
        public ActionResult Create()
        {
            ViewBag.AutorId = new SelectList(db.Autores, "AutorId", "Nombre");
            return View();
        }

        // POST: Noticia/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NoticiaId,Titulo,Contenido,Publicacion,Imagen,AutorId")] Noticia noticia)
        {
            if (ModelState.IsValid)
            {
                db.Noticias.Add(noticia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AutorId = new SelectList(db.Autores, "AutorId", "Nombre", noticia.AutorId);
            return View(noticia);
        }

        // GET: Noticia/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Noticia noticia = db.Noticias.Find(id);
            if (noticia == null)
            {
                return HttpNotFound();
            }
            ViewBag.AutorId = new SelectList(db.Autores, "AutorId", "Nombre", noticia.AutorId);
            return View(noticia);
        }

        // POST: Noticia/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NoticiaId,Titulo,Contenido,Publicacion,Imagen,AutorId")] Noticia noticia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(noticia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AutorId = new SelectList(db.Autores, "AutorId", "Nombre", noticia.AutorId);
            return View(noticia);
        }

        // GET: Noticia/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Noticia noticia = db.Noticias.Find(id);
            if (noticia == null)
            {
                return HttpNotFound();
            }
            return View(noticia);
        }

        // POST: Noticia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Noticia noticia = db.Noticias.Find(id);
            db.Noticias.Remove(noticia);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
