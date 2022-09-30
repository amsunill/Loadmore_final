using LOADMORE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
//jklsdnnfl;asjdflkkasjdfl
///'/kjhfkhsdkfhsdkjfh

namespace LOADMORE.Controllers
{
    public class LoadmoreController : Controller
    {
        private readonly AppDbCon _con;
        private readonly EmployeeRepository _employeeRepository;
        public LoadmoreController(AppDbCon con,EmployeeRepository emp)
        {
            _con = con;
            _employeeRepository  = emp;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(int? i)
        {
            var page = 10;
            var inn = i * page;
            dynamic model = new ExpandoObject();
            if (i == 1)
                model.employee = _con.Employees.Take(page).ToList();
            else
                model.employee = _con.Employees.Skip(Convert.ToInt32(inn-10)).Take(page).ToList();
            model.totalCount = _con.Employees.ToList().Count();
            return Json(model);
        }
        //[HttpGet]
        //public IActionResult Emplist(int? pagenumber)
        //{ 
        //    var model = _employeeRepository.GetEmployees(pagenumber);
        //    return Json(model);
        //}
    }
}
