﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserInterface.Controllers
{
    public class HomePageController : Controller
    {
        public ActionResult AdaugaApartament()
        {

            return View("AdaugaApartament", "HomePage");
        }


    }
}