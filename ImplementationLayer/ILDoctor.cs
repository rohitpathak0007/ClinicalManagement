using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using InterfaceLayer;
using BusinessAccessLayer;
using CommonUtility;
using System.Diagnostics;

namespace ImplementationLayer
{
   public class ILDoctor : IDoctor
   {
       #region Global Declarations


       int levelCounter = 0;
       string strGuid = string.Empty;
       ClsDoctor objClsDoctor = null;
       

       #endregion


       public List<DoctorModel> GetDoctorDetail(UserModel objUserModel)
        {
            objClsDoctor = new ClsDoctor();
            try
            {
                return objClsDoctor.GetDoctorDetail(objUserModel);
            }
            catch (Exception ex)
            {

                strGuid = DateTime.Now.ToString("ddMMyyyyhhmmss");
                levelCounter = 0;
                ClsLogging.writefile("---------------------------------------------------------------------------------", ClsLogging.LogType.CL_Exception);
                ClsLogging.writefile("Exception Ouccred Section Start", ClsLogging.LogType.CL_Exception);
                ClsLogging.writefile("Unique ID " + strGuid, ClsLogging.LogType.CL_Exception);
                ClsLogging.writefile("Exception In GetDoctorDetail" + ex.Message, ClsLogging.LogType.CL_Exception);
                foreach (StackFrame stackFrame in new StackTrace(ex, true).GetFrames().Where(x => x.GetFileLineNumber() != 0 && x.GetFileName() != null))
                {
                    ClsLogging.writefile("Level : " + Convert.ToString(++levelCounter), ClsLogging.LogType.CL_Exception);
                    ClsLogging.writefile("File Name : " + stackFrame.GetFileName(), ClsLogging.LogType.CL_Exception);
                    ClsLogging.writefile("Method Name : " + stackFrame.GetMethod().Name, ClsLogging.LogType.CL_Exception);
                    ClsLogging.writefile("Line Number : " + stackFrame.GetFileLineNumber(), ClsLogging.LogType.CL_Exception);
                    ClsLogging.writefile("Col Number : " + stackFrame.GetFileColumnNumber(), ClsLogging.LogType.CL_Exception);
                }
                ClsLogging.writefile("Exception Ouccred Section End", ClsLogging.LogType.CL_Exception);
                throw ex;
            }
        }

        public DoctorModel GetByID(long ID, string Cmd)
        {
            objClsDoctor = new ClsDoctor();
            try
            {
                return objClsDoctor.GetByID(ID, Cmd);
            }
            catch (Exception ex)
            {

                strGuid = DateTime.Now.ToString("ddMMyyyyhhmmss");
                levelCounter = 0;
                ClsLogging.writefile("---------------------------------------------------------------------------------", ClsLogging.LogType.CL_Exception);
                ClsLogging.writefile("Exception Ouccred Section Start", ClsLogging.LogType.CL_Exception);
                ClsLogging.writefile("Unique ID " + strGuid, ClsLogging.LogType.CL_Exception);
                ClsLogging.writefile("Exception In GetByID" + ex.Message, ClsLogging.LogType.CL_Exception);
                foreach (StackFrame stackFrame in new StackTrace(ex, true).GetFrames().Where(x => x.GetFileLineNumber() != 0 && x.GetFileName() != null))
                {
                    ClsLogging.writefile("Level : " + Convert.ToString(++levelCounter), ClsLogging.LogType.CL_Exception);
                    ClsLogging.writefile("File Name : " + stackFrame.GetFileName(), ClsLogging.LogType.CL_Exception);
                    ClsLogging.writefile("Method Name : " + stackFrame.GetMethod().Name, ClsLogging.LogType.CL_Exception);
                    ClsLogging.writefile("Line Number : " + stackFrame.GetFileLineNumber(), ClsLogging.LogType.CL_Exception);
                    ClsLogging.writefile("Col Number : " + stackFrame.GetFileColumnNumber(), ClsLogging.LogType.CL_Exception);
                }
                ClsLogging.writefile("Exception Ouccred Section End", ClsLogging.LogType.CL_Exception);
                throw ex;
            }
        }

        public string UpdateData(DoctorModel objDoctorModel)
        {
            objClsDoctor = new ClsDoctor();
            try
            {
                return objClsDoctor.UpdateData(objDoctorModel);
            }
            catch (Exception ex)
            {

                strGuid = DateTime.Now.ToString("ddMMyyyyhhmmss");
                levelCounter = 0;
                ClsLogging.writefile("---------------------------------------------------------------------------------", ClsLogging.LogType.CL_Exception);
                ClsLogging.writefile("Exception Ouccred Section Start", ClsLogging.LogType.CL_Exception);
                ClsLogging.writefile("Unique ID " + strGuid, ClsLogging.LogType.CL_Exception);
                ClsLogging.writefile("Exception In UpdateData" + ex.Message, ClsLogging.LogType.CL_Exception);
                foreach (StackFrame stackFrame in new StackTrace(ex, true).GetFrames().Where(x => x.GetFileLineNumber() != 0 && x.GetFileName() != null))
                {
                    ClsLogging.writefile("Level : " + Convert.ToString(++levelCounter), ClsLogging.LogType.CL_Exception);
                    ClsLogging.writefile("File Name : " + stackFrame.GetFileName(), ClsLogging.LogType.CL_Exception);
                    ClsLogging.writefile("Method Name : " + stackFrame.GetMethod().Name, ClsLogging.LogType.CL_Exception);
                    ClsLogging.writefile("Line Number : " + stackFrame.GetFileLineNumber(), ClsLogging.LogType.CL_Exception);
                    ClsLogging.writefile("Col Number : " + stackFrame.GetFileColumnNumber(), ClsLogging.LogType.CL_Exception);
                }
                ClsLogging.writefile("Exception Ouccred Section End", ClsLogging.LogType.CL_Exception);
                throw ex;
            }
        }

        public string DeleteData(int ID)
        {
            objClsDoctor = new ClsDoctor();
            try
            {
                return objClsDoctor.DeleteData(ID);
            }
            catch (Exception ex)
            {

                strGuid = DateTime.Now.ToString("ddMMyyyyhhmmss");
                levelCounter = 0;
                ClsLogging.writefile("---------------------------------------------------------------------------------", ClsLogging.LogType.CL_Exception);
                ClsLogging.writefile("Exception Ouccred Section Start", ClsLogging.LogType.CL_Exception);
                ClsLogging.writefile("Unique ID " + strGuid, ClsLogging.LogType.CL_Exception);
                ClsLogging.writefile("Exception In DeleteData" + ex.Message, ClsLogging.LogType.CL_Exception);
                foreach (StackFrame stackFrame in new StackTrace(ex, true).GetFrames().Where(x => x.GetFileLineNumber() != 0 && x.GetFileName() != null))
                {
                    ClsLogging.writefile("Level : " + Convert.ToString(++levelCounter), ClsLogging.LogType.CL_Exception);
                    ClsLogging.writefile("File Name : " + stackFrame.GetFileName(), ClsLogging.LogType.CL_Exception);
                    ClsLogging.writefile("Method Name : " + stackFrame.GetMethod().Name, ClsLogging.LogType.CL_Exception);
                    ClsLogging.writefile("Line Number : " + stackFrame.GetFileLineNumber(), ClsLogging.LogType.CL_Exception);
                    ClsLogging.writefile("Col Number : " + stackFrame.GetFileColumnNumber(), ClsLogging.LogType.CL_Exception);
                }
                ClsLogging.writefile("Exception Ouccred Section End", ClsLogging.LogType.CL_Exception);
                throw ex;
            }
        }


        public string InsertDoctor(DoctorModel objDoctorModel) 
        {
            objClsDoctor = new ClsDoctor();
            try
            {
                return objClsDoctor.InsertDoctor(objDoctorModel);
            }
            catch (Exception ex)
            {

                strGuid = DateTime.Now.ToString("ddMMyyyyhhmmss");
                levelCounter = 0;
                ClsLogging.writefile("---------------------------------------------------------------------------------", ClsLogging.LogType.CL_Exception);
                ClsLogging.writefile("Exception Ouccred Section Start", ClsLogging.LogType.CL_Exception);
                ClsLogging.writefile("Unique ID " + strGuid, ClsLogging.LogType.CL_Exception);
                ClsLogging.writefile("Exception In InsertDoctor" + ex.Message, ClsLogging.LogType.CL_Exception);
                foreach (StackFrame stackFrame in new StackTrace(ex, true).GetFrames().Where(x => x.GetFileLineNumber() != 0 && x.GetFileName() != null))
                {
                    ClsLogging.writefile("Level : " + Convert.ToString(++levelCounter), ClsLogging.LogType.CL_Exception);
                    ClsLogging.writefile("File Name : " + stackFrame.GetFileName(), ClsLogging.LogType.CL_Exception);
                    ClsLogging.writefile("Method Name : " + stackFrame.GetMethod().Name, ClsLogging.LogType.CL_Exception);
                    ClsLogging.writefile("Line Number : " + stackFrame.GetFileLineNumber(), ClsLogging.LogType.CL_Exception);
                    ClsLogging.writefile("Col Number : " + stackFrame.GetFileColumnNumber(), ClsLogging.LogType.CL_Exception);
                }
                ClsLogging.writefile("Exception Ouccred Section End", ClsLogging.LogType.CL_Exception);
                throw ex;
            }
        }
    }
}
