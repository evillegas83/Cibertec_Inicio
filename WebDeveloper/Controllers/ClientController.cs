using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    [Authorize]
    public class ClientController : Controller
    {
        //private ClientData _client = new ClientData();
        // GET: Client
        //private IDataAccess<Client> _client;

        private ClientData _client;

        public ClientController(ClientData client)
        {
            _client = client;
        }

        public ActionResult Index()
        {
            ViewBag.Title = Resources.Resource.Client_Title;
            return View(_client.GetList());
        }

        public ActionResult Create()
        {
            return View(new Client());
        }

        [HttpPost]
        public ActionResult Create(Client client)
        {
            if (ModelState.IsValid)
            {
                _client.Add(client);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int id = 0)
        {
            var obj = _client.GetClientById(id);

            if (obj == null)
                RedirectToAction("Index");
            return View(obj);

        }

        [HttpPost]
        public ActionResult Edit(Client client)
        {
            if (ModelState.IsValid)
            {
                _client.Update(client);
                return RedirectToAction("Index");
            }
            return View();
        }


        public ActionResult Delete(int id = 0)
        {

            var obj = _client.GetClientById(id);

            if(obj == null)
                RedirectToAction("Index");
            return View(obj);
            
            
        }

        [HttpPost]
        public ActionResult Delete(Client client)
        {
            if(_client.Delete(client)>0)
                return RedirectToAction("Index");
            return View(client);

        }


    }
}