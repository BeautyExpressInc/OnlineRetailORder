using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineRetailORder.Models;

namespace OnlineRetailORder.Controllers
{
    public class OnlineRetailOrdersController : Controller
    {
        private OnlineRetailOrderContext db = new OnlineRetailOrderContext();

        // GET: OnlineRetailOrders
        public ActionResult Index()
        {
            OnlineRetailOrderContext or = new OnlineRetailOrderContext();
            List<_Online_Retail_HDR> listOrders = or._Online_Retail_HDRs.ToList();
            return View();
        }

        // GET: OnlineRetailOrders/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            _Online_Retail_HDR onlineRetailOrder = db._Online_Retail_HDRs.Find(id);
            if (onlineRetailOrder == null)
            {
                return HttpNotFound();
            }
            return View(onlineRetailOrder);
        }

        // GET: OnlineRetailOrders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OnlineRetailOrders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "od_id,od_OrderSource,od_date,od_status,od_shipping_last_name,od_shipping_email,ShippingDate,ShippedBy,total_discounts,subtotal_price,total_price,discount_code,discount_type,discount_amount")] _Online_Retail_HDR onlineRetailOrder)
        {
            if (ModelState.IsValid)
            {
                db._Online_Retail_HDRs.Add(onlineRetailOrder);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(onlineRetailOrder);
        }

        // GET: OnlineRetailOrders/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            _Online_Retail_HDR onlineRetailOrder = db._Online_Retail_HDRs.Find(id);
            if (onlineRetailOrder == null)
            {
                return HttpNotFound();
            }
            return View(onlineRetailOrder);
        }

        // POST: OnlineRetailOrders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RetailOrderId,od_OrderSource,od_date,od_status,od_shipping_last_name,od_shipping_email,ShippingDate,ShippedBy,total_discounts,subtotal_price,total_price,discount_code,discount_type,discount_amount")] _Online_Retail_HDR onlineRetailOrder)
        {
            if (ModelState.IsValid)
            {
                db.Entry(onlineRetailOrder).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(onlineRetailOrder);
        }

        // GET: OnlineRetailOrders/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            _Online_Retail_HDR onlineRetailOrder = db._Online_Retail_HDRs.Find(id);
            if (onlineRetailOrder == null)
            {
                return HttpNotFound();
            }
            return View(onlineRetailOrder);
        }

        // POST: OnlineRetailOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            _Online_Retail_HDR onlineRetailOrder = db._Online_Retail_HDRs.Find(id);
            db._Online_Retail_HDRs.Remove(onlineRetailOrder);
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
