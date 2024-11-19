using Microsoft.AspNetCore.Mvc;
using MVCIntro.Models;
using MVCIntro.ViewModels;

namespace MVCIntro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>
{
    new Product { Category = "Animal", Image = "https://images.twinkl.co.uk/tw1n/image/private/t_630/u/ux/frog-2_ver_1.jpg", Name = "Frog", Description = "Kvakvakva", Price = 123, Color = "green" },
    new Product { Category = "Still animal", Image = "https://media.istockphoto.com/id/1276678779/photo/poison-dart-frogs.jpg?s=612x612&w=0&k=20&c=camBWAGVijIQPVFiDXYNQ2xi6Pww9hvkkajaboMShWg=", Name = "Lyagushka", Description = "Kvakvakvakva", Price = 999, Color = "red" },
    new Product { Category = "Another animal", Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQVYNykfv4k2aYg3nj_NZYVvE9aLMcu0D-L3w&s", Name = "Froggy", Description = "KVvaaaaaaaaaaaaaaaaaaaaa", Price = 250, Color = "blue" }
};


            HomeVM homeVM = new HomeVM
            {
                Products = products
            };

            return View(homeVM);
        }
    }
}
