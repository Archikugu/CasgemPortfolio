using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CasgemPortfolio.Models.Entities;

namespace CasgemPortfolio.Controllers
{
    public class ReferenceController : Controller
    {
        CasgemPortfolioDbEntities db = new CasgemPortfolioDbEntities();

        public ActionResult Index()
        {
            return View();
        }
    }
}