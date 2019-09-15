using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using InterfaceLayer;
using BusinessAccessLayer;
using CommonUtility;
using System.Diagnostics;

namespace ImplementationLayer
{
    public class ILCustomer : ICustomer
    {
        #region Global Declaration

        int levelCounter = 0;
        string strGuid = string.Empty;
        ClsCustomer objClsCustomer = null;

        #endregion

        public string InsertAppointment(CustomerModel objCustomerModel)
        {
            objClsCustomer = new ClsCustomer();
            try
            {
                return objClsCustomer.InsertAppointment(objCustomerModel);
            }
            catch (Exception ex)
            {

                strGuid = DateTime.Now.ToString("ddMMyyyyhhmmss");
                levelCounter = 0;
                ClsLogging.writefile("---------------------------------------------------------------------------------", ClsLogging.LogType.CL_Exception);
                ClsLogging.writefile("Exception Ouccred Section Start", ClsLogging.LogType.CL_Exception);
                ClsLogging.writefile("Unique ID " + strGuid, ClsLogging.LogType.CL_Exception);
                ClsLogging.writefile("Exception In InsertAppointment" + ex.Message, ClsLogging.LogType.CL_Exception);
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

        public UserModel isValidUser(UserModel objUserModel)
        {
            objClsCustomer = new ClsCustomer();
            try
            {
                return objClsCustomer.isValidUser(objUserModel);
            }
            catch (Exception ex)
            {

                strGuid = DateTime.Now.ToString("ddMMyyyyhhmmss");
                levelCounter = 0;
                ClsLogging.writefile("---------------------------------------------------------------------------------", ClsLogging.LogType.CL_Exception);
                ClsLogging.writefile("Exception Ouccred Section Start", ClsLogging.LogType.CL_Exception);
                ClsLogging.writefile("Unique ID " + strGuid, ClsLogging.LogType.CL_Exception);
                ClsLogging.writefile("Exception In isValidUser" + ex.Message, ClsLogging.LogType.CL_Exception);
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

        public List<CustomerModel> GetCustomerDetail(UserModel objUserModel)
        {
            objClsCustomer = new ClsCustomer();
            try
            {
                return objClsCustomer.GetCustomerDetail(objUserModel);
            }
            catch (Exception ex)
            {

                strGuid = DateTime.Now.ToString("ddMMyyyyhhmmss");
                levelCounter = 0;
                ClsLogging.writefile("---------------------------------------------------------------------------------", ClsLogging.LogType.CL_Exception);
                ClsLogging.writefile("Exception Ouccred Section Start", ClsLogging.LogType.CL_Exception);
                ClsLogging.writefile("Unique ID " + strGuid, ClsLogging.LogType.CL_Exception);
                ClsLogging.writefile("Exception In GetCustomerDetail" + ex.Message, ClsLogging.LogType.CL_Exception);
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

        public CustomerModel GetByID(Int64 ID, string Cmd)
        {
            objClsCustomer = new ClsCustomer();
            try
            {
                return objClsCustomer.GetByID(ID, Cmd);
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

       public string UpdateData(CustomerModel objCustomerModel)
        {
            objClsCustomer = new ClsCustomer();
            try
            {
                return objClsCustomer.UpdateData(objCustomerModel);
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

       public string DeleteData(int id)
       {
           objClsCustomer = new ClsCustomer();
           try
           {
               return objClsCustomer.DeleteData(id);
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


       public List<DropDown> GetDropDown(string CMD)
       {
           objClsCustomer = new ClsCustomer();
           try
           {
               return objClsCustomer.GetDropDown(CMD);
           }
           catch (Exception ex)
           {

               strGuid = DateTime.Now.ToString("ddMMyyyyhhmmss");
               levelCounter = 0;
               ClsLogging.writefile("---------------------------------------------------------------------------------", ClsLogging.LogType.CL_Exception);
               ClsLogging.writefile("Exception Ouccred Section Start", ClsLogging.LogType.CL_Exception);
               ClsLogging.writefile("Unique ID " + strGuid, ClsLogging.LogType.CL_Exception);
               ClsLogging.writefile("Exception In GetDropDown" + ex.Message, ClsLogging.LogType.CL_Exception);
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


       public string InsertCustomer(CustomerModel objCustomerModel)
       {
           objClsCustomer = new ClsCustomer();
           try
           {
               return objClsCustomer.InsertAppointment(objCustomerModel);
           }
           catch (Exception ex)
           {

               strGuid = DateTime.Now.ToString("ddMMyyyyhhmmss");
               levelCounter = 0;
               ClsLogging.writefile("---------------------------------------------------------------------------------", ClsLogging.LogType.CL_Exception);
               ClsLogging.writefile("Exception Ouccred Section Start", ClsLogging.LogType.CL_Exception);
               ClsLogging.writefile("Unique ID " + strGuid, ClsLogging.LogType.CL_Exception);
               ClsLogging.writefile("Exception In InsertCustomer" + ex.Message, ClsLogging.LogType.CL_Exception);
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
