using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class RazorController : Controller
    {
        // GET: Razor
        public ActionResult Index()
        {
            var clients = new List<Client>
            {
                new Client {ID = 1, Name = "Jose", LastName = "Perez" , DateCreation = DateTime.Now},
                new Client {ID = 2, Name = "Juan", LastName = "Perez" ,DateCreation = DateTime.Now},
                new Client {ID = 3, Name = "Maria", LastName = "Perez" ,DateCreation = DateTime.Now},
                new Client {ID = 4, Name = "Pedro", LastName = "Perez" ,DateCreation = DateTime.Now},
                new Client {ID = 5, Name = "Marcos", LastName = "Perez",DateCreation = DateTime.Now },
                new Client {ID = 6, Name = "Lucas", LastName = "Perez",DateCreation = DateTime.Now },
                new Client {ID = 7, Name = "Pablo", LastName = "Perez" ,DateCreation = DateTime.Now},
                new Client {ID = 8, Name = "Mateo", LastName = "Perez" ,DateCreation = DateTime.Now}
            };
            return View(clients);
        }

        public ActionResult Product()
        {
            //ViewBag.Free = "Free!!";
            var productData = new ProductData();
            return View(productData.GetFakeProducts());
        }
    }
}