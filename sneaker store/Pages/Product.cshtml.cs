using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sneaker_store.Models;

namespace sneaker_store.Pages
{
    public class ProductsModel : PageModel
    {
        private readonly AppDataContexts _db;


        public List<Product> Products { get; set; }
        public ProductsModel(AppDataContexts db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Products = _db.Products.ToList();
        }
    }
}
