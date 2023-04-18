using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day4.Areas.Admin.Controllers
{
    [HandleError(View = "AdminError")]
    public class AdminController : Controller
    {
        // GET: Admin/Admin
        public ActionResult Index()
        {
            throw new Exception();
        }

      
           
    }
}