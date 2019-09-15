using InterfaceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using ImplementationLayer;

namespace ClinicalManagement.Controllers
{
    public class MecidineController : Controller
    {

        #region Global Declarations

        IMecidine objIMecidine = null;
        List<MecidineModel> lstMecidineModel = null;
        MecidineModel objMecidineModel = null;

        private void CommonView()
        {
            objIMecidine = new ILMecidine();
            lstMecidineModel = new List<MecidineModel>();
            lstMecidineModel = objIMecidine.GetMecidineDetail(SessionDetails.Fetch_UserDetails);
        }

        #endregion

        public ActionResult Index()
        {
            CommonView();
            return View(lstMecidineModel);
        }

        public ActionResult ViewData(int id, string strType)
        {
            objIMecidine = new ILMecidine();
            objMecidineModel = new MecidineModel();
            objMecidineModel = objIMecidine.GetByID(id, "Mecidine");
            if (strType == "View")
                return View("ViewData", objMecidineModel);
            else
                return View("UpdateData", objMecidineModel);
        }

        public ActionResult DeleteData()
        {
            objIMecidine = new ILMecidine();
            int id = Convert.ToInt32(Request.Form["hdnID"]);
            string msg = objIMecidine.DeleteData(id);
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
            return View("Index", lstMecidineModel);
        }

        [HttpPost]
        public ActionResult UpdateData(MecidineModel objMecidineModel)
        {
            objIMecidine = new ILMecidine();
            string msg = objIMecidine.UpdateData(objMecidineModel);
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
            return View("Index", lstMecidineModel);
        }

    }
}
