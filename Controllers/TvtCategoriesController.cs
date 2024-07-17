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
    public class TvtCategoriesController : Controller
    {
        private TvtK22CNTLesson11DbEntities1 db = new TvtK22CNTLesson11DbEntities1();

        // GET: TvtCategories
        public ActionResult TvtIndex()
        {
            return View(db.TvtCategory.ToList());
        }

        // GET: TvtCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TvtCategory tvtCategory = db.TvtCategory.Find(id);
            if (tvtCategory == null)
            {
                return HttpNotFound();
            }
            return View(tvtCategory);
        }

        // GET: TvtCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TvtCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TvtID,TvtCateName,TvtStatus")] TvtCategory tvtCategory)
        {
            if (ModelState.IsValid)
            {
                db.TvtCategory.Add(tvtCategory);
                db.SaveChanges();
                return RedirectToAction("TvtIndex");
            }

            return View(tvtCategory);
        }

        // GET: TvtCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TvtCategory tvtCategory = db.TvtCategory.Find(id);
            if (tvtCategory == null)
            {
                return HttpNotFound();
            }
            return View(tvtCategory);
        }

        // POST: TvtCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TvtID,TvtCateName,TvtStatus")] TvtCategory tvtCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tvtCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("TvtIndex");
            }
            return View(tvtCategory);
        }

        // GET: TvtCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TvtCategory tvtCategory = db.TvtCategory.Find(id);
            if (tvtCategory == null)
            {
                return HttpNotFound();
            }
            return View(tvtCategory);
        }

        // POST: TvtCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TvtCategory tvtCategory = db.TvtCategory.Find(id);
            db.TvtCategory.Remove(tvtCategory);
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
