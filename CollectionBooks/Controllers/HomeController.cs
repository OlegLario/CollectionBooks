using BookLayerApp.BLL.Services;
using BookLayerApp.DAL.Entities;
using BookLayerApp.DAL.Interfaces;
using BookLayerApp.DAL.Repositories;
using CollectionBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CollectionBooks.Controllers
{
    public class HomeController : Controller
    {
        IRepository repo;
        public HomeController(IRepository r)
        {
            repo = r;
        }

        public HomeController()
        {
            repo = new BookRepository();
        }
        /*public ActionResult Index()
        {
            var model = repo.GetAllBooks();
            return View(model);
        }*/
        public ActionResult Index(string searchString)
        {
            var model = repo.SearchAll(searchString);
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Book book) 
        {
            if (ModelState.IsValid)
            {
                repo.Create(book);
                repo.Save();
                return RedirectToAction("Index");
            }
            return View("Create");
        }
        

    }
}