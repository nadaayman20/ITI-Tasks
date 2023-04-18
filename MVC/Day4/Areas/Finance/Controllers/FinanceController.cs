using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day4.Areas.Finance.Controllers
{
    [HandleError(View = "FinanceError")]
    public class FinanceController : Controller
    {
        // GET: Finance/Finance
        public ActionResult Index()
        {
            throw new Exception();
        }
    }
}