using InAndOut.Context;
using InAndOut.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace InAndOut.Controllers
{
    public class ExpensesCategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ExpensesCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<ExpensesCategoriesModel> objList = _context.ExpensesCategories;
            return View(objList);
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ExpensesCategoriesModel obj)
        {
            _context.ExpensesCategories.Add(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");
           
        }
        public IActionResult Delete(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _context.ExpensesCategories.Find(id);
            if(obj == null)
            { return NotFound(); }
            

            return View(obj);

        }
        [HttpPost]
        public IActionResult DeletePost(int? id)
        {

            var obj = _context.ExpensesCategories.Find(id);
            if(obj==null)
            {
                return NotFound();
            }
            _context.ExpensesCategories.Remove(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Update(int? id)
        {
            var obj = _context.ExpensesCategories.Find(id);
            return View(obj);
        }
        [HttpPost]
        public IActionResult Update(ExpensesCategoriesModel obj)
        {
            if(obj == null) { return NotFound(); }
            _context.ExpensesCategories.Update(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
