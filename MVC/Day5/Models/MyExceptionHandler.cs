using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day5.Models
{
    public class MyExceptionHandler : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            if (filterContext == null)
            {
                throw new ArgumentNullException("filterContext");
            }

            if (!filterContext.IsChildAction && !filterContext.ExceptionHandled && filterContext.HttpContext.IsCustomErrorEnabled)
            {
                Exception exception = filterContext.Exception;
                if (new HttpException(null, exception).GetHttpCode() == 500 && ExceptionType.IsInstanceOfType(exception))
                {
                    string controllerName = (string)filterContext.RouteData.Values["controller"];
                    string actionName = (string)filterContext.RouteData.Values["action"];
                    HandleErrorInfo model = new HandleErrorInfo(filterContext.Exception, controllerName, actionName);
                    filterContext.Result = new ViewResult
                    {
                        ViewName = "OrderError",
                        MasterName = Master,
                        ViewData = new ViewDataDictionary<HandleErrorInfo>(model),
                        TempData = filterContext.Controller.TempData
                    };
                    filterContext.ExceptionHandled = true;
                    filterContext.HttpContext.Response.Clear();
                    filterContext.HttpContext.Response.StatusCode = 500;
                    filterContext.HttpContext.Response.TrySkipIisCustomErrors = true;
                }
            }
        }
    }
}