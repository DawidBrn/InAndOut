using InAndOut.Context;
using InAndOut.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace InAndOut.Controllers
{
    public class ExpensesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ExpensesController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<ExpensesModel> objList = _db.Expenses;
            return View(objList);
        }
        public IActionResult Create()
        {
            IEnumerable<SelectListItem> CategoryDropdown = _db.ExpensesCategories.Select(i => new SelectListItem
            {
                Text = i.CategoryName,
                Value = i.Id.ToString()
            });
            ViewBag.CategoryDropdown = CategoryDropdown;
           
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ExpensesModel obj)
        {
            if (ModelState.IsValid) {
                _db.Expenses.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }
        public IActionResult Delete(int? id)
        {
            if(id == null || id==0)
            {
                return NotFound();
            }
            var obj = _db.Expenses.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            
            return View(obj);
        }
        [HttpPost]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Expenses.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }   

        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Expenses.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        public IActionResult Update(ExpensesModel obj)
        {
             
            if (ModelState.IsValid) {
                _db.Expenses.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
                return View(obj);
        }



    }
}
