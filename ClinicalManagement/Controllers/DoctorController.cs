using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using ImplementationLayer;
using InterfaceLayer;
using CommonUtility;

namespace ClinicalManagement.Controllers
{
    public class DoctorController : Controller
    {
        #region Global Declarations

        IDoctor objIDoctor = null;
        List<DoctorModel> lstDoctorModel = null;
        DoctorModel objDoctorModel = null;
        ICustomer objICustomer = null;


        #endregion

        private void CommonView()
        {
            objIDoctor = new ILDoctor();
            lstDoctorModel = new List<DoctorModel>();
            lstDoctorModel = objIDoctor.GetDoctorDetail(SessionDetails.Fetch_UserDetails);
        }

        private void BindDegree()
        {
            ViewBag.Degree = new SelectList(objICustomer.GetDropDown("DEGREE"), "Value", "Text");
        }

        public ActionResult Index()
        {
            CommonView();
            return View(lstDoctorModel);
        }

       
        public ActionResult ViewData(int id, string strType)
        {
            objIDoctor = new ILDoctor();
            objDoctorModel = new DoctorModel();
            objICustomer = new ILCustomer();
            objDoctorModel = objIDoctor.GetByID(id, "Doctor");
            if (strType == "View")
                return View("ViewData", objDoctorModel);
            else
            {
                BindDegree();
                return View("UpdateData", objDoctorModel);
            }
        }

        public ActionResult DeleteData()
        {
            objIDoctor = new ILDoctor();
            int id = Convert.ToInt32(Request.Form["hdnID"]);
            string msg = objIDoctor.DeleteData(id);
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
            return View("Index", lstDoctorModel);
        }

        [HttpPost]
        public ActionResult UpdateData(DoctorModel objDoctorModel)
        {
            objIDoctor = new ILDoctor();
            string msg = objIDoctor.UpdateData(objDoctorModel);
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
            return View("Index", lstDoctorModel);
        }

        public ActionResult AddDoctor()
        {
            objICustomer = new ILCustomer();
            BindDegree();
            return View();
        }

        [HttpPost]
        public ActionResult AddDoctor(DoctorModel objDoctorModel)
        {
            objIDoctor = new ILDoctor();
            string msg = objIDoctor.InsertDoctor(objDoctorModel);
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
            return View("Index", lstDoctorModel);
        }

    }
}
