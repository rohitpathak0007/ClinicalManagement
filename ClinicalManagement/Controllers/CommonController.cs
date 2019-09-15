using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicalManagement
{
    public class CommonController : Controller
    {
        #region  Session Mangement

        private UserModel GetSessionDetail
        {
            get
            {
                return Session["UserDetails"] as UserModel;
            }
        }

        public PartialViewResult SessionUserPartial()
        {
            if (Session["UserDetails"] != null)
                return PartialView(GetSessionDetail);
            else
                return null;
        }

        #endregion


        public ActionResult Exception()
        {
            return View();
        }

        public ActionResult XSS()
        {
            return View();
        }

        public ActionResult SessionOut()
        {
            return View();
        }

       

    }
}
