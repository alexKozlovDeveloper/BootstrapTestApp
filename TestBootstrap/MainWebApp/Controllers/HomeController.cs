using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MainWebApp.Models;

namespace MainWebApp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var model = GetModel();

            return View(model);
        }

        private List<UserInfo> GetModel()
        {
            return new List<UserInfo>
            {
                new UserInfo{FirstName = "f1", LastName = "l1", Age = 10},
                new UserInfo{FirstName = "f2", LastName = "l2", Age = 11},
                new UserInfo{FirstName = "f3", LastName = "l3", Age = 12}
            };
        }

    }
}
