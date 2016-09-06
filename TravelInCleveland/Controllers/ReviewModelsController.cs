using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TravelInCleveland.Models;

namespace TravelInCleveland.Controllers
{
    public class ReviewModelsController : Controller
    {
        private TravelInClevelandContext db = new TravelInClevelandContext();

        // GET: ReviewModels
        public ActionResult Index()
        {
            return View(db.ReviewModels.ToList());
        }

        // GET: ReviewModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReviewModel reviewModel = db.ReviewModels.Find(id);
            if (reviewModel == null)
            {
                return HttpNotFound();
            }
            return View(reviewModel);
        }

        // GET: ReviewModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReviewModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDNumber,Rating,ReviewTitle,ReviewContent,WillReturn")] ReviewModel reviewModel)
        {
            if (ModelState.IsValid)
            {
                db.ReviewModels.Add(reviewModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(reviewModel);
        }

        // GET: ReviewModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReviewModel reviewModel = db.ReviewModels.Find(id);
            if (reviewModel == null)
            {
                return HttpNotFound();
            }
            return View(reviewModel);
        }

        // POST: ReviewModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDNumber,Rating,ReviewTitle,ReviewContent,WillReturn")] ReviewModel reviewModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reviewModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reviewModel);
        }

        // GET: ReviewModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReviewModel reviewModel = db.ReviewModels.Find(id);
            if (reviewModel == null)
            {
                return HttpNotFound();
            }
            return View(reviewModel);
        }

        // POST: ReviewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ReviewModel reviewModel = db.ReviewModels.Find(id);
            db.ReviewModels.Remove(reviewModel);
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
