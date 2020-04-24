using BNP.APIClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BNPwebform.Controllers
{
    public class MovimentoController : Controller
    {
        // GET: Movimento
        public ActionResult Index()
        {
            return View();
        }

        // GET: Movimento/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Movimento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movimento/Create
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

        // GET: Movimento/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Movimento/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
                return View();
            }
        }

        // GET: Movimento/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
            {
        }

        // POST: Movimento/Delete/5
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

        public PartialViewResult GridLista()
        {
            var client = new MovimentoClient(Session);
            var result = client.Listar();
            return PartialView("_GridConvenios", result);
        }
    }
}
