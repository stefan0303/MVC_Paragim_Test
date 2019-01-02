using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParagimMVC.Models;

namespace ParagimMVC.Controllers
{
    public class GetDataFromViewController : Controller
    {
        public IActionResult Index()
        {
            Employee employee = new Employee
            {
                Age = 12,
                Name = "Gosho",
                Id = 1
            };
            return View(employee);
        }

        public IActionResult EditData()
        {
            Employee employee = new Employee
            {
                Age = 12,
                Name = "Gosho",
                Id = 1
            };
            return View(employee);
        }
        [HttpGet]
        public void GetDataWithHttpGet(int id, string name, int age)
        {
            //we get the data with get method
           
        }
        [HttpPost]
        public void GetDataWithHttpPost(Employee employee)
        {
           //we get the data with post method
            TryUpdateModelAsync(employee);
        }

    }
}
