﻿using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using RareMediumAcademy_03102022.Models.Pages;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace RareMediumAcademy_03102022.Controllers
{
    public class MC_GrabNGoController : PageController<MC_GrabNGo>
    {
        public ActionResult Index(MC_GrabNGo currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return View(currentPage);
        }
    }
}