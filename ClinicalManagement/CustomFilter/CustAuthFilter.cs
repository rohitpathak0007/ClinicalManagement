using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicalManagement
{
    public class CustAuthFilter : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (HttpContext.Current.User != null)
            {
                if (HttpContext.Current.Session["UserDetails"] == null)
                {
                    base.OnAuthorization(filterContext);
                    filterContext.Result = new RedirectToRouteResult(
                        new System.Web.Routing.RouteValueDictionary
                               {
                                       { "langCode", filterContext.RouteData.Values[ "langCode" ] },
                                       { "controller", "Common" },
                                       { "action", "SessionOut" },
                                       { "ReturnUrl", filterContext.HttpContext.Request.RawUrl }
                               });
                }
            }
            else
            {
                base.OnAuthorization(filterContext);
                filterContext.Result = new RedirectToRouteResult(
                    new System.Web.Routing.RouteValueDictionary
                               {
                                       { "langCode", filterContext.RouteData.Values[ "langCode" ] },
                                       { "controller", "Common" },
                                       { "action", "SessionOut" },
                                       { "ReturnUrl", filterContext.HttpContext.Request.RawUrl }
                               });
            }


        }
    }
}
