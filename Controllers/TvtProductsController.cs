using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TvtK22CNTLesson11_2210900063.Models;

namespace TvtK22CNTLesson11_2210900063.Controllers
{
    public class TvtProductsController : Controller
    {
        private TvtK22CNTLesson11DbEntities1 db = new TvtK22CNTLesson11DbEntities1();

        // GET: TvtProducts
        public ActionResult TvtIndex()
        {
            return View(db.TvtProduct.ToList());
        }

        // GET: TvtProducts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TvtProduct tvtProduct = db.TvtProduct.Find(id);
            if (tvtProduct == null)
            {
                return HttpNotFound();
            }
            return View(tvtProduct);
        }

        // GET: TvtProducts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TvtProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TvtId2210900063,TvtProName,TvtQty,TvtPrice,TvtCateld,TvtActive")] TvtProduct tvtProduct)
        {
            if (ModelState.IsValid)
            {
                db.TvtProduct.Add(tvtProduct);
                db.SaveChanges();
                return RedirectToAction("TvtIndex");
            }

            return View(tvtProduct);
        }

        // GET: TvtProducts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TvtProduct tvtProduct = db.TvtProduct.Find(id);
            if (tvtProduct == null)
            {
                return HttpNotFound();
            }
            return View(tvtProduct);
        }

        // POST: TvtProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TvtId2210900063,TvtProName,TvtQty,TvtPrice,TvtCateld,TvtActive")] TvtProduct tvtProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tvtProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("TvtIndex");
            }
            return View(tvtProduct);
        }

        // GET: TvtProducts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TvtProduct tvtProduct = db.TvtProduct.Find(id);
            if (tvtProduct == null)
            {
                return HttpNotFound();
            }
            return View(tvtProduct);
        }

        // POST: TvtProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TvtProduct tvtProduct = db.TvtProduct.Find(id);
            db.TvtProduct.Remove(tvtProduct);
            db.SaveChanges();
            return RedirectToAction("TvtIndex");
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
