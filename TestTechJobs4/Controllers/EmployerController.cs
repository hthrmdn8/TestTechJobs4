﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestTechJobs4.Models;
using TestTechJobs4.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestTechJobs4.Controllers
{
    public class EmployerController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult ProcessAddEmployerForm()
        {
            return View();
        }

        public IActionResult About(int id)
        {
            return View();
        }
    }
}