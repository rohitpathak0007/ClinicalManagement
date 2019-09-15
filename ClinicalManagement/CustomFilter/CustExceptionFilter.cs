using CommonUtility;
using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ClinicalManagement
{
    public class CustExceptionFilter : FilterAttribute, IExceptionFilter
    {
        #region Global Declaration

        StringBuilder objStringBuilder = null;
        StackTrace st = null;
        int levelCounter = 0;

        #endregion

        #region Exception Handle

        public void OnException(ExceptionContext filterContext)
        {
            objStringBuilder = new StringBuilder();
            st = new StackTrace(filterContext.Exception, true);
            objStringBuilder.AppendLine("Controller Name : " + filterContext.RouteData.Values["controller"]);
            objStringBuilder.AppendLine("<br/>" + "Action Name : " + filterContext.RouteData.Values["action"]);
            objStringBuilder.AppendLine("<br/>" + "Message : " + filterContext.Exception.Message);
            foreach (StackFrame stackFrame in st.GetFrames().Where(x => x.GetFileLineNumber() != 0 && x.GetFileName() != null))
            {
                objStringBuilder.AppendLine("<br/>" + "Level : " + Convert.ToString(++levelCounter));
                objStringBuilder.AppendLine("<br/>" + "File Name : " + stackFrame.GetFileName());
                objStringBuilder.AppendLine("<br/>" + "Method Name : " + stackFrame.GetMethod().Name);
                objStringBuilder.AppendLine("<br/>" + "Line Number : " + stackFrame.GetFileLineNumber());
                objStringBuilder.AppendLine("<br/>" + "Col Number : " + stackFrame.GetFileColumnNumber());
            }
            
            ClsLogging.writefile("---------------------------------------------------------------------------------", ClsLogging.LogType.CL_Exception);
            ClsLogging.writefile("Exception Ouccred Section Start", ClsLogging.LogType.CL_Exception);
            ClsLogging.writefile(objStringBuilder.ToString().Replace("<br/>", "\t\t\t\t"), ClsLogging.LogType.CL_Exception);
            ClsLogging.writefile("Exception Ouccred Section End", ClsLogging.LogType.CL_Exception);
            if (filterContext.Exception is HttpAntiForgeryException)
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(
              new
               {
                   action = "XSS",
                   controller = "Common",
                   id = new HttpException(null, filterContext.Exception).GetHttpCode().ToString(),
                   exceptionAction = (string)filterContext.RouteData.Values["action"],
                   exceptionController = (string)filterContext.RouteData.Values["controller"]
               }));
            }
            else
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(
            new
            {
                action = "Exception",
                controller = "Common",
                id = new HttpException(null, filterContext.Exception).GetHttpCode().ToString(),
                exceptionAction = (string)filterContext.RouteData.Values["action"],
                exceptionController = (string)filterContext.RouteData.Values["controller"]
            }));
            }
            filterContext.ExceptionHandled = true;
        }

        #endregion
    }
}