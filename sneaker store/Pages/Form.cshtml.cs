using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sneaker_store.Models;

namespace sneaker_store.Pages
{
  
    public class FormModel : PageModel
    {
        public readonly AppDataContexts _db;

        [BindProperty]
        public Product Products { get; set; }

        public FormModel(AppDataContexts db) 
        {
            _db = db;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            _db.Products.Add(Products);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
