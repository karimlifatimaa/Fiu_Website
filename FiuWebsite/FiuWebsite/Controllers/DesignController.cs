using FiuWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace FiuWebsite.Controllers
{
    public class DesignController : Controller
    {
        public IActionResult Index()
        {
            Furniture furniture3 = new Furniture()
            {
               
                Name = "Chair",
                Price = 550
            };
            Furniture furniture4 = new Furniture()
            {

                Name = "Chair",
                Price = 150
            };
            Furniture furniture1 = new Furniture()
            {
              
                Name = "Sofa",
                Price = 250
            };
            Furniture furniture5 = new Furniture()
            {

                Name = "Sofa",
                Price = 450
            };

            Furniture furniture2 = new Furniture()
            {
               
                Name = "Table",
                Price = 180
            };
            Furniture furniture6 = new Furniture()
            {

                Name = "Table",
                Price = 100
            };


            List<Furniture> furnitures = new List<Furniture>();
           
            furnitures.Add(furniture1);
            furnitures.Add(furniture2);
            furnitures.Add(furniture3);
            furnitures.Add(furniture4);
            furnitures.Add(furniture5);
            furnitures.Add(furniture6);






            ViewBag.FurnitureList= furnitures;

            return View(furnitures);
        }
    }
}
