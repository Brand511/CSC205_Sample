using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CSC205_Madeira.Models;


namespace CSC205_Madeira.Controllers
{
    public class CarsController : Controller
    {
        List<Car> cars;

        public CarsController()
        {
            cars = new List<Car>
            {
                new Car() { id=0, make = "Acura", model = "TL", color = "red", year = 2004 },
                new Car() { id=0, make = "Honda", model = "Civic", color = "blue", year = 2014 },
            };
        }
            
        // GET: Cars
        public ActionResult Index()
        {
            return View(cars);
        }

        // GET: Cars/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cars/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cars/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cars/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cars/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cars/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cars/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
