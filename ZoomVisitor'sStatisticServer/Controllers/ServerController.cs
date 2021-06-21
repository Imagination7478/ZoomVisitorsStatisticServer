using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ZoomVisitor_sStatisticServer.Controllers
{
    [ApiController]
    public class ServerController : Controller
    {
        [HttpGet("/access_token")]
        public IActionResult getAccessToken(string code)
        {
            Console.WriteLine(code);
            return Ok("Ok");
        }





        //-----------------------------------------------------------//
        // GET: ServerController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ServerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ServerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ServerController/Create
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

        // GET: ServerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ServerController/Edit/5
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

        // GET: ServerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ServerController/Delete/5
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
