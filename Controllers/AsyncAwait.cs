using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ParagimMVC.Models;

namespace ParagimMVC.Controllers
{
    public class AsyncAwait : Controller
    {
        private Employee employee;
        private Task<int> access;
        public async Task<IActionResult> Index()
        {
            employee = new Employee();
            if (access == null)
            {
                employee.Name = "Waiting...........";
                return View(employee);
            }
            access = DoSomethingAsync();
            // from my understanding the waiting should be done here.
            int x = await access;
            employee.Name = "RESULTTTT";
            return View(employee);
        }
        async Task<int> DoSomethingAsync()
        {
            // is this executed on a background thread?
            System.Threading.Thread.Sleep(10000);
            return 1;
        }

        public ActionResult Getsome()
        {
            return null;
        }
        public int Test23()
        {

            return 666;
        }
        public PartialViewResult GetsomeTtResult()
        {
            return PartialView();
        }
    }

}
