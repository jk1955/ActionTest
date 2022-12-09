using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ActionTest2.Models;
using System.Collections.Specialized;
using Microsoft.AspNetCore.Http.Extensions;

namespace ActionTest2.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index(int id, string name)
        {
            string tmp = Request.GetDisplayUrl();

            TempData["fromPerson"] = "true";

            TempData["url"] = tmp;

            TempData["id"] = id;

            TempData["name"] = name;

            //return View();
            return RedirectToAction("Index", "Home");
        }
    }
}