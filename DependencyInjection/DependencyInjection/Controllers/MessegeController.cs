using DependencyInjection.Interface;
using DependencyInjection.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    public class MessegeController : Controller
    {
        private readonly IMessege _services;
        public MessegeController(IMessege services)
        {
            _services = services;
        }

        // GET: MessegeController
        public ActionResult Index()
        {
            return View(_services.GetAllMesseges());
        }

        // GET: MessegeController/Details/5
        public ActionResult Details(int id)
        {
            return View(_services.GetMessegeById(id));
        }

        // GET: MessegeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MessegeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Messege messege)
        {
            if (ModelState.IsValid)
            {
                _services.AddMessege(messege);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(messege);
            }
        }

        // GET: MessegeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_services.GetMessegeById(id));
        }

        // POST: MessegeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Messege messege)
        {
            if (ModelState.IsValid)
            {
                _services.UpdateMessege(messege);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(messege);
            }
        }

        // GET: MessegeController/Delete/5


        // POST: MessegeController/Delete/5
       
        public ActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                _services.DeleteMessege(id);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(_services.GetMessegeById(id));
            }
        }
    }
}