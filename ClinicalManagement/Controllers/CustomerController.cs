using System.Web.Mvc;
using Model;
using ImplementationLayer;
using InterfaceLayer;
using CommonUtility;
using System.Web.Security;
using System;

namespace ClinicalManagement
{
    [CustExceptionFilter]
    public class CustomerController : Controller
    {
        ICustomer objICustomer = null;
        string[] status;

        public ActionResult Index()
        {
            if (Session["UserDetails"] != null)
                SessionDestory();

            if (TempData["Message"] != null)
            {
                if (TempData["Message"] == "Mail")
                {
                    ViewBag.MFlag = "S";
                    ViewBag.message = "* We'll contact you by phone & email later";
                }
                else
                {
                    ViewBag.MFlag = "F";
                    ViewBag.message = "Wrong UserName or Password...!";
                }
            }
            return View();
        }

        [HttpPost]
        public ActionResult Index(CustomerModel objCustomerModel)
        {
            objICustomer = new ILCustomer();
            objCustomerModel.CreatedIP = ClsIPAddress.GetIPAddress();
            status = (objICustomer.InsertAppointment(objCustomerModel)).Split('|');
            if (status[0] == "00")
                TempData["Message"] = "Mail";
            ModelState.Clear();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Login(UserModel objUserModel)
        {
            if (ModelState.IsValid)
            {
                objICustomer = new ILCustomer();
                var IsExit = objICustomer.isValidUser(objUserModel);
                if (IsExit == null)
                    TempData["Message"] = "Login";
                else
                {
                    Session["UserDetails"] = objUserModel;
                    switch (objUserModel.UserTypeValue)
                    {
                        case 1: return RedirectToActionPermanent("Index", "Home");
                        case 2: return RedirectToActionPermanent("Index", "Doctor");
                        case 3: return RedirectToActionPermanent("Home", "Home");
                        case 4: return RedirectToActionPermanent("Index", "Mecidine");
                        default: return RedirectToActionPermanent("XSS", "Common");
                    }
                }
            }
            return RedirectToAction("Index");
        }

        public ActionResult LogOut()
        {
            SessionDestory();
            return RedirectToActionPermanent("Index", "Customer");
        }

        private void SessionDestory()
        {
            Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
            Response.Cache.SetCacheability(System.Web.HttpCacheability.NoCache);
            Response.Cache.SetNoStore();
            FormsAuthentication.SignOut();
            Session.Abandon();
        }
    }
}
