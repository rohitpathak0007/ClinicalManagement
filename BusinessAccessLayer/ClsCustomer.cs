using DataAccess;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessAccessLayer
{
    public class ClsCustomer
    {
        #region Global Declarations

        List<CustomerModel> lstCustomerModel = null;
        CustomerModel objCustomerModel = null;
        DoctorModel objDoctorModel = null;
        DropDown objDropDown = null;
        List<DropDown> lstDropDown = null;

        #endregion

        public string InsertAppointment(CustomerModel objCustomerModel)
        {
            SqlParameter[] parameter = {
                                           new SqlParameter("@FName",objCustomerModel.FirstName),
                                           new SqlParameter("@LName",objCustomerModel.LastName),
                                           new SqlParameter("@Gender",objCustomerModel.Gender),
                                           new SqlParameter("@Age",objCustomerModel.Age),
                                           new SqlParameter("@Desc",objCustomerModel.Descriptions),
                                           new SqlParameter("@Email",objCustomerModel.EmailId),
                                           new SqlParameter("@Phone",objCustomerModel.PhoneNumber),  
                                           new SqlParameter("@DOB",objCustomerModel.DOB),  
                                            new SqlParameter("@ApptTime",objCustomerModel.AppDateTime),  
                                           new SqlParameter("@DoctorID",objCustomerModel.DoctorID), 
                                           new SqlParameter("@STATUS",SqlDbType.VarChar,50){Direction=ParameterDirection.Output}
                                      };
            return SQLHelper.ExecuteNonQueryOutputResult(SQLHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, DBConstants.PRC_INSERT_CUSTOMER, "@STATUS", parameter);

        }

        public UserModel isValidUser(UserModel objUserModel)
        {
            SqlParameter[] parameter = {
                                            new SqlParameter("@UserCode",objUserModel.UserCode),
                                            new SqlParameter("@Password",objUserModel.Password),
                                   };

            using (SqlDataReader rdr = SQLHelper.ExecuteReader(SQLHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, DBConstants.PRC_Valid_Uers, parameter))
            {
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        if (rdr["UserID"] != DBNull.Value)
                            objUserModel.UserID = Convert.ToInt64(rdr["UserID"]);
                        if (rdr["UserName"] != DBNull.Value)
                            objUserModel.UserName = Convert.ToString(rdr["UserName"]);
                        if (rdr["UserCode"] != DBNull.Value)
                            objUserModel.UserCode = Convert.ToString(rdr["UserCode"]);
                        if (rdr["Password"] != DBNull.Value)
                            objUserModel.Password = Convert.ToString(rdr["Password"]);
                        if (rdr["IsActive"] != DBNull.Value)
                            objUserModel.IsActive = Convert.ToBoolean(rdr["IsActive"]);
                        if (rdr["UserType"] != DBNull.Value)
                            objUserModel.UserType = Convert.ToString(rdr["UserType"]);
                        if (rdr["UserTypeValue"] != DBNull.Value)
                            objUserModel.UserTypeValue = Convert.ToInt32(rdr["UserTypeValue"]);
                    }
                }
                else
                    return null;
            }
            return objUserModel;
        }

        public CustomerModel GetByID(Int64 ID, string Cmd)
        {
            objDoctorModel = new DoctorModel();
            objCustomerModel = new CustomerModel();

            SqlParameter[] parameter = { 
                                        new SqlParameter("@ID",ID),
                                        new SqlParameter("@CMD",Cmd)
                                     };
            using (SqlDataReader rdr = SQLHelper.ExecuteReader(SQLHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, DBConstants.PRC_GETBYID, parameter))
            {
                while (rdr.Read())
                {
                    if (rdr["CustomerID"] != DBNull.Value)
                        objCustomerModel.AppointmentID = Convert.ToInt64(rdr["CustomerID"]);
                    if (rdr["FirstName"] != DBNull.Value)
                        objCustomerModel.FirstName = Convert.ToString(rdr["FirstName"]);
                    if (rdr["LastName"] != DBNull.Value)
                        objCustomerModel.LastName = Convert.ToString(rdr["LastName"]);
                    if (rdr["EmailId"] != DBNull.Value)
                        objCustomerModel.EmailId = Convert.ToString(rdr["EmailId"]);
                    if (rdr["PhoneNumber"] != DBNull.Value)
                        objCustomerModel.PhoneNumber = Convert.ToString(rdr["PhoneNumber"]);
                    if (rdr["DOB"] != DBNull.Value)
                        objCustomerModel.DOB = Convert.ToDateTime(rdr["DOB"]);
                    if (rdr["Age"] != DBNull.Value)
                        objCustomerModel.Age = Convert.ToInt32(rdr["Age"]);
                    if (rdr["Gender"] != DBNull.Value)
                        objCustomerModel.Gender = Convert.ToString(rdr["Gender"]);
                    if (rdr["AppointmentTime"] != DBNull.Value)
                        objCustomerModel.AppDateTime = Convert.ToDateTime(rdr["AppointmentTime"]);
                    if (rdr["Descriptions"] != DBNull.Value)
                        objCustomerModel.Descriptions = Convert.ToString(rdr["Descriptions"]);
                    if (rdr["Doctor"] != DBNull.Value)
                        objCustomerModel.DoctorID = Convert.ToInt32(rdr["Doctor"]);

                    objCustomerModel.Doctor = objDoctorModel;
                }
            }
            return objCustomerModel;
        }

        public List<CustomerModel> GetCustomerDetail(UserModel objUserModel)
        {
            SqlParameter[] parameter = { 
                                        new SqlParameter("@UserType",objUserModel.UserTypeValue),
                                        new SqlParameter("@UserCode",objUserModel.UserCode)
                                     };
            using (SqlDataReader rdr = SQLHelper.ExecuteReader(SQLHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, DBConstants.PRC_GET_Customer, parameter))
            {
                lstCustomerModel = new List<CustomerModel>();
                while (rdr.Read())
                {
                    objDoctorModel = new DoctorModel();
                    objCustomerModel = new CustomerModel();
                    if (rdr["CustomerID"] != DBNull.Value)
                        objCustomerModel.AppointmentID = Convert.ToInt64(rdr["CustomerID"]);
                    if (rdr["FirstName"] != DBNull.Value)
                        objCustomerModel.FirstName = Convert.ToString(rdr["FirstName"]);
                    if (rdr["LastName"] != DBNull.Value)
                        objCustomerModel.LastName = Convert.ToString(rdr["LastName"]);
                    if (rdr["EmailId"] != DBNull.Value)
                        objCustomerModel.EmailId = Convert.ToString(rdr["EmailId"]);
                    if (rdr["PhoneNumber"] != DBNull.Value)
                        objCustomerModel.PhoneNumber = Convert.ToString(rdr["PhoneNumber"]);
                    if (rdr["DOB"] != DBNull.Value)
                        objCustomerModel.DOB = Convert.ToDateTime(rdr["DOB"]);
                    if (rdr["Age"] != DBNull.Value)
                        objCustomerModel.Age = Convert.ToInt32(rdr["Age"]);
                    if (rdr["Gender"] != DBNull.Value)
                        objCustomerModel.Gender = Convert.ToString(rdr["Gender"]);
                    if (rdr["AppointmentTime"] != DBNull.Value)
                        objCustomerModel.AppDateTime = Convert.ToDateTime(rdr["AppointmentTime"]);
                    if (rdr["Descriptions"] != DBNull.Value)
                        objCustomerModel.Descriptions = Convert.ToString(rdr["Descriptions"]);
                    if (rdr["Doctor"] != DBNull.Value)
                        objDoctorModel.FirstName = Convert.ToString(rdr["Doctor"]);

                    objCustomerModel.Doctor = objDoctorModel;
                    lstCustomerModel.Add(objCustomerModel);
                }
            }
            return lstCustomerModel;
        }

        public string UpdateData(CustomerModel objCustomerModel)
        {
            SqlParameter[] param = {
                                     new SqlParameter("@CustID",objCustomerModel.AppointmentID),
                                      new SqlParameter("@FName",objCustomerModel.FirstName),
                                       new SqlParameter("@LName",objCustomerModel.LastName),
                                        new SqlParameter("@Gender",objCustomerModel.Gender),
                                         new SqlParameter("@Age",objCustomerModel.Age),
                                          new SqlParameter("@Email",objCustomerModel.EmailId),
                                          new SqlParameter("@DoctorID",objCustomerModel.DoctorID),
                                           new SqlParameter("@Phone",objCustomerModel.PhoneNumber),
                                            new SqlParameter("@Desc",objCustomerModel.Descriptions),
                                            new SqlParameter("@Status",SqlDbType.VarChar,50){Direction=ParameterDirection.Output}
                                 };
            return SQLHelper.ExecuteNonQueryOutputResult(SQLHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, DBConstants.PRC_UPDATE_CUSTOMER, "@STATUS", param);
        }

        public string DeleteData(int ID)
        {
            SqlParameter[] param = {
                new SqlParameter("@ID",ID),
                new SqlParameter("@Status",SqlDbType.VarChar,50){Direction=ParameterDirection.Output}
                                };
            return SQLHelper.ExecuteNonQueryOutputResult(SQLHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, DBConstants.PRC_GET_DELETE_CUSTOMER, "@STATUS", param);

        }

        public List<DropDown> GetDropDown(string CMD)
        {
            SqlParameter[] parameter = { 
                                        new SqlParameter("@CMD",CMD),
                                       
                                     };
            using (SqlDataReader rdr = SQLHelper.ExecuteReader(SQLHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, DBConstants.PRC_GET_DropDown, parameter))
            {
                lstDropDown = new List<DropDown>();
                while (rdr.Read())
                {
                    objDropDown = new DropDown();
                    if (rdr["Text"] != DBNull.Value)
                        objDropDown.Text = Convert.ToString(rdr["Text"]);
                    if (rdr["Value"] != DBNull.Value)
                        objDropDown.Value = Convert.ToString(rdr["Value"]);

                    lstDropDown.Add(objDropDown);
                }
            }

            return lstDropDown;
        }

        string InsertCustomer(CustomerModel objCustomerModel)
        {
            SqlParameter[] param = {
                                     new SqlParameter("@CustID",objCustomerModel.AppointmentID),
                                      new SqlParameter("@FName",objCustomerModel.FirstName),
                                       new SqlParameter("@LName",objCustomerModel.LastName),
                                        new SqlParameter("@Gender",objCustomerModel.Gender),
                                         new SqlParameter("@Age",objCustomerModel.Age),
                                          new SqlParameter("@Email",objCustomerModel.EmailId),
                                           new SqlParameter("@Phone",objCustomerModel.PhoneNumber),
                                            new SqlParameter("@Desc",objCustomerModel.Descriptions),
                                            new SqlParameter("@DOB",objCustomerModel.DOB),
                                            new SqlParameter("@Status",SqlDbType.VarChar,50){Direction=ParameterDirection.Output}
                                 };
            return SQLHelper.ExecuteNonQueryOutputResult(SQLHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, DBConstants.PRC_INSERT_CUSTOMER, "@STATUS", param);
       
        }
    }
}
