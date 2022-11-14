using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using RareMediumAcademy_03102022.Models.Pages.ProTipsListings;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace RareMediumAcademy_03102022.Controllers.ProTipsListings
{
    public class Beef_ProTipsController : PageController<Beef_ProTips>
    {
        public ActionResult Index(Beef_ProTips currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return View(currentPage);
        }
    }
}