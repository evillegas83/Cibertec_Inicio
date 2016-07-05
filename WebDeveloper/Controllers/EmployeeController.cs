using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class EmployeeController : Controller
    {
        //EmployeeData _employee = new EmployeeData();
        // GET: Employee

        EmployeeData _employee;

        public EmployeeController(EmployeeData employee)
        {
            _employee = employee;
        }

        public ActionResult Index()
        {
            return View(_employee.GetList());
        }

        public ActionResult Create()
        {
            return View(new Employee());
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employee.Add(employee);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int id = 0)
        {
            var obj = _employee.GetEmployeeById(id);

            if (obj == null)
                RedirectToAction("Index");
            return View(obj);

        }

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employee.Update(employee);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int id = 0)
        {
            var obj = _employee.GetEmployeeById(id);

            if (obj == null)
                RedirectToAction("Index");
            return View(obj);
        }

        [HttpPost]
        public ActionResult Delete(Employee employee)
        {
            if (_employee.Delete(employee) > 0)
                return RedirectToAction("Index");
            return View(employee);
        }

    }
}