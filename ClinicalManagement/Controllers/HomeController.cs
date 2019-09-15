using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using ImplementationLayer;
using InterfaceLayer;
using ClinicalManagement;

namespace ClinicalManagement.Controllers
{
    [CustAuthFilter]
    [CustExceptionFilter]
    public class HomeController : Controller
    {
        #region

        ICustomer objICustomer = null;
        List<CustomerModel> lstCustomerModel = null;
        CustomerModel objCustomerModel = null;
        

        #endregion

        public ActionResult Index()
        {

            return View();
        }

        private void CommonView()
        {
            objICustomer = new ILCustomer();
            lstCustomerModel = new List<CustomerModel>();
            lstCustomerModel = objICustomer.GetCustomerDetail(SessionDetails.Fetch_UserDetails);
        }


        private void GetDoctor()
        {
            ViewBag.Doctor = new SelectList(objICustomer.GetDropDown("DOCTOR"), "Value", "Text");
        }

        public ActionResult Home()
        {
            CommonView();
            return View(lstCustomerModel);
        }

       

        public ActionResult ViewData(int id, string strType)
        {
            objICustomer = new ILCustomer();
            objCustomerModel = new CustomerModel();
            objCustomerModel = objICustomer.GetByID(id, "Customer");
            if (strType == "View")
            {
                GetDoctor();
                return View("ViewData", objCustomerModel);
            }
            else
            {
                GetDoctor();
                return View("EditData", objCustomerModel);
            }
        }

        public ActionResult DeleteData()
        {
            objICustomer = new ILCustomer();
            int id = Convert.ToInt32(Request.Form["hdnID"]);
            string msg = objICustomer.DeleteData(id);
            string[] strmsg = msg.Split('|');
            if (strmsg[0] == "00")
            {
                ViewBag.MFlag = "S";
                ViewBag.message = strmsg[1];
            }
            else
            {
                ViewBag.MFlag = "F";
                ViewBag.message = strmsg[1];
            }
            CommonView();
            return View("Home", lstCustomerModel);
        }

        [HttpPost]
        public ActionResult UpdateData(CustomerModel objCustomerModel)
        {
            objICustomer = new ILCustomer();
            string msg = objICustomer.UpdateData(objCustomerModel);
            string[] strmsg = msg.Split('|');
            if (strmsg[0] == "00")
            {
                ViewBag.MFlag = "S";
                ViewBag.message = strmsg[1];
            }
            else
            {
                ViewBag.MFlag = "F";
                ViewBag.message = strmsg[1];
            }
            CommonView();
            return View("Home", lstCustomerModel);
        }


        public ActionResult AddCustomer()
        {
            objICustomer = new ILCustomer();
            GetDoctor();
            return View();
        }

        [HttpPost]
       public ActionResult AddCustomer(CustomerModel objCustomerModel)
        {
            objICustomer = new ILCustomer();
            string msg = objICustomer.InsertAppointment(objCustomerModel);
            string[] strmsg = msg.Split('|');
            if (strmsg[0] == "00")
            {
                ViewBag.MFlag = "S";
                ViewBag.message = strmsg[1];
            }
            else
            {
                ViewBag.MFlag = "F";
                ViewBag.message = strmsg[1];
            }
            CommonView();
            return View("Home", lstCustomerModel);
        }

    }
}
