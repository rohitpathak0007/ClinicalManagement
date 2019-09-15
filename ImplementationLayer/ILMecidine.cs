using BusinessAccessLayer;
using CommonUtility;
using InterfaceLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ImplementationLayer
{
    public class ILMecidine : IMecidine
   {
       #region Global Declarations 


       int levelCounter = 0;
        string strGuid = string.Empty;
        ClsMecidicne objClsMecidicne = null;


        #endregion


        public List<MecidineModel> GetMecidineDetail(UserModel objUserModel)
        {
            objClsMecidicne = new ClsMecidicne();
            try
            {
                return objClsMecidicne.GetMecidineDetail(objUserModel);
            }
            catch (Exception ex)
            {

                strGuid = DateTime.Now.ToString("ddMMyyyyhhmmss");
                levelCounter = 0;
                ClsLogging.writefile("---------------------------------------------------------------------------------", ClsLogging.LogType.CL_Exception);
                ClsLogging.writefile("Exception Ouccred Section Start", ClsLogging.LogType.CL_Exception);
                ClsLogging.writefile("Unique ID " + strGuid, ClsLogging.LogType.CL_Exception);
                ClsLogging.writefile("Exception In GetMecidineDetail" + ex.Message, ClsLogging.LogType.CL_Exception);
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

        public MecidineModel GetByID(long ID, string Cmd)
        {
            objClsMecidicne = new ClsMecidicne();
            try
            {
                return objClsMecidicne.GetByID(ID, Cmd);
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

        public string UpdateData(MecidineModel objMecidineModel)
        {
            objClsMecidicne = new ClsMecidicne();
            try
            {
                return objClsMecidicne.UpdateData(objMecidineModel);
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
            objClsMecidicne = new ClsMecidicne();
            try
            {
                return objClsMecidicne.DeleteData(ID);
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
   }
}
