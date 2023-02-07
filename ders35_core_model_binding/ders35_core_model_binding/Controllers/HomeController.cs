using ders35_core_model_binding.Models;
using Microsoft.AspNetCore.Mvc;

namespace ders35_core_model_binding.Controllers
{
    public class HomeController : Controller
    {
        NorthwindContext context = new NorthwindContext();

        public IActionResult Index()
        {
            List<Category> categories = context.Categories.ToList();
            //Categories tablosu buraya gelicek
            return View(categories);
        }

        public IActionResult KategoriliUrunler(int id)
        {
            List<Product> productList = context.Products.Where(p => p.CategoryID == id).ToList();
            return View(productList);
        }

        public IActionResult UrunDetay()
        {
            return View();
        }
    }
}
