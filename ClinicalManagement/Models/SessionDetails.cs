using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;

namespace ClinicalManagement
{
    public class SessionDetails
    {
        public static UserModel Fetch_UserDetails
        {
            get
            {
                return HttpContext.Current.Session["UserDetails"] as UserModel;
            }
        }
    }
}