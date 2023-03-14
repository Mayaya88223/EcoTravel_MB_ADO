using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcoTravel_MB_AspMVC.Controllers
{
    public class LogementController : Controller
    {
        // GET: LogementController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LogementController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LogementController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LogementController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LogementController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LogementController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LogementController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LogementController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
