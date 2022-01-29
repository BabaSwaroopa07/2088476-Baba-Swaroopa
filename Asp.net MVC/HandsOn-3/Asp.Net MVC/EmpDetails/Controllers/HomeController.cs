using EmpDetails.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EmpDetails.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetEmployeeList()
        {
            List<Employee> emplist = new List<Employee>
            {
                new Employee{Id=1,Name="John",Salary=100000,IsPermanent=true},
                new Employee{Id=2,Name="Baba",Salary=50000,IsPermanent=true},
                new Employee{Id=3,Name="Swaroopa",Salary=25000,IsPermanent=false},
                new Employee{Id=4,Name="Pokemon",Salary=35000,IsPermanent=true}
            };

            return View(emplist);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
