using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {

            List<Department> departments = new List<Department>();

            departments.Add(new Department {id = 1 , name = "Vendas"});
            departments.Add(new Department { id = 2, name = "Fashion" });

            return View(departments);
        }
    }
}