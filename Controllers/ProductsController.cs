using Microsoft.AspNetCore.Mvc;
using NetApp.Models;

namespace NetApp.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            var listProducts = GetProducts();
            return View(listProducts);
        }


        public IActionResult Detail(int id)
        {
            var product = GetProductById(id);
            
            if (product == null)
            {
                return NotFound();
            }

            return PartialView("_ProductDetail",product);
        }

        private static Product? GetProductById(int id)
        {
            var listProducts = GetProducts();
            return listProducts.FirstOrDefault((product) => product.Id == id);
        }

        private static List<Product> GetProducts()
        {
            return
            [
                new Product {Id = 1, Name = "Laptop", Price = 1100, Description = "A computer." },
                new Product {Id = 2, Name = "Shoe", Price = 23.5, Description = "A single shoe."}
            ];
        }
    }
}