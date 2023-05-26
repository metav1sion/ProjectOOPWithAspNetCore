using Microsoft.AspNetCore.Mvc;
using Proje_OOP.Entity;
using Proje_OOP.ProjeContext;

namespace Proje_OOP.Controllers
{
    public class ProductController : Controller
    {
        Context context = new Context();


        public IActionResult Index()
        {
            var values = context.products.ToList();
            return View(values);
        }

        [HttpGet] // alttaki metotun sayfa yüklenince çalışmasını istiyorum
        public IActionResult AddProduct()
        {

            return View();
        }
        [HttpPost] // post yapıldığında
        public IActionResult AddProduct(Product p)
        {
            context.products.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index"); // beni indexe yönlendir.
        }
        
        public IActionResult DeleteProduct(int id)
        {
            var value = context.products.Where(x=>x.ID == id).FirstOrDefault();
            context.products.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        
        public IActionResult UpdateProduct(int id)
        {
            var value = context.products.Where(x=>x.ID== id).FirstOrDefault();
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product p)
        {
            var value = context.products.Where(x=>x.ID == p.ID).FirstOrDefault();
            value.Name = p.Name;
            value.Price = p.Price;
            value.Stock = p.Stock;
            context.SaveChanges();
            
            return RedirectToAction("Index");
        }

    }
}
