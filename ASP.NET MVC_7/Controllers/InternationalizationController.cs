using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Web;
using System.Web.Mvc;

using System.Globalization;
using System.Threading;
using ASP.NET_MVC_7.Models;

namespace ASP.NET_MVC_7.Controllers
{
    public class InternationalizationController : Controller
    {

        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            base.Initialize(requestContext);
            if (Session["CurrentCulture"] != null)
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo(Session["CurrentCulture"].ToString());
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(Session["CurrentCulture"].ToString());
            }
        }

        public ActionResult ChangeCulture(string ddlCulture)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(ddlCulture);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(ddlCulture);

            Session["CurrentCulture"] = ddlCulture;
            return View("Index");
        }
  
        public ActionResult Index()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult Index(UserViewModel user)
        {
            if (ModelState.IsValid)
            {
               
            }
            return View();
        }
    }
}