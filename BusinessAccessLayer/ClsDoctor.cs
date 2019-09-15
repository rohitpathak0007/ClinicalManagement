using DataAccess;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BusinessAccessLayer
{
    public class ClsDoctor
    {
        #region Global Declarations

        List<DoctorModel> lstDoctorModel = null;
        DoctorModel objDoctorModel = null;

        #endregion

        public List<DoctorModel> GetDoctorDetail(UserModel objUserModel)
        {
            lstDoctorModel = new List<DoctorModel>();
            SqlParameter[] parameter = { 
                                        new SqlParameter("@UserType",objUserModel.UserTypeValue),
                                        //new SqlParameter("@UserCode",objUserModel.UserCode)
                                     };
            using (SqlDataReader rdr = SQLHelper.ExecuteReader(SQLHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, DBConstants.PRC_GET_DOCTOR_DETAILS, parameter))
            {
                while (rdr.Read())
                {
                    objDoctorModel = new DoctorModel();
                    if (rdr["DoctorID"] != DBNull.Value)
                        objDoctorModel.DoctorID = Convert.ToInt32(rdr["DoctorID"]);
                    if (rdr["FirstName"] != DBNull.Value)
                        objDoctorModel.FirstName = Convert.ToString(rdr["FirstName"]);
                    if (rdr["LastName"] != DBNull.Value)
                        objDoctorModel.LastName = Convert.ToString(rdr["LastName"]);
                    if (rdr["Gender"] != DBNull.Value)
                        objDoctorModel.Gender = Convert.ToString(rdr["Gender"]);
                    if (rdr["DOB"] != DBNull.Value)
                        objDoctorModel.DOB = Convert.ToDateTime(rdr["DOB"]);
                    if (rdr["Age"] != DBNull.Value)
                        objDoctorModel.Age = Convert.ToInt32(rdr["Age"]);
                    if (rdr["ContactNumber"] != DBNull.Value)
                        objDoctorModel.PhoneNumber = Convert.ToString(rdr["ContactNumber"]);
                    if (rdr["Descriptions"] != DBNull.Value)
                        objDoctorModel.AboutDoctor = Convert.ToString(rdr["Descriptions"]);
                    if (rdr["Address"] != DBNull.Value)
                        objDoctorModel.Address = Convert.ToString(rdr["Address"]);
                    if (rdr["FrmTime"] != DBNull.Value)
                        objDoctorModel.FrmTime = Convert.ToString(rdr["FrmTime"]);
                    if (rdr["ToTime"] != DBNull.Value)
                        objDoctorModel.ToTime = Convert.ToString(rdr["ToTime"]);
                    if (rdr["UserName"] != DBNull.Value)
                        objDoctorModel.Username = Convert.ToString(rdr["UserName"]);
                    if (rdr["LKValue"] != DBNull.Value)
                        objDoctorModel.Type = Convert.ToString(rdr["LKValue"]);
                    if (rdr["UserCode"] != DBNull.Value)
                        objDoctorModel.UserCode = Convert.ToString(rdr["UserCode"]);

                    lstDoctorModel.Add(objDoctorModel);
                }
            }
            return lstDoctorModel;
        }

        public string DeleteData(int ID)
        {
            SqlParameter[] param = {
                new SqlParameter("@ID",ID),
                new SqlParameter("@Status",SqlDbType.VarChar,50){Direction=ParameterDirection.Output}
                                };
            return SQLHelper.ExecuteNonQueryOutputResult(SQLHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, DBConstants.PRC_GET_DELETE_DOCTOR, "@STATUS", param);

        }

        public DoctorModel GetByID(Int64 ID, string Cmd)
        {

            SqlParameter[] parameter = { 
                                        new SqlParameter("@ID",ID),
                                        new SqlParameter("@CMD",Cmd)
                                     };
            using (SqlDataReader rdr = SQLHelper.ExecuteReader(SQLHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, DBConstants.PRC_GETBYID, parameter))
            {

                objDoctorModel = new DoctorModel();
                while (rdr.Read())
                {

                    if (rdr["DoctorID"] != DBNull.Value)
                        objDoctorModel.DoctorID = Convert.ToInt32(rdr["DoctorID"]);
                    if (rdr["FirstName"] != DBNull.Value)
                        objDoctorModel.FirstName = Convert.ToString(rdr["FirstName"]);
                    if (rdr["LastName"] != DBNull.Value)
                        objDoctorModel.LastName = Convert.ToString(rdr["LastName"]);
                    if (rdr["Gender"] != DBNull.Value)
                        objDoctorModel.Gender = Convert.ToString(rdr["Gender"]);
                    if (rdr["DOB"] != DBNull.Value)
                        objDoctorModel.DOB = Convert.ToDateTime(rdr["DOB"]);
                    if (rdr["Age"] != DBNull.Value)
                        objDoctorModel.Age = Convert.ToInt32(rdr["Age"]);
                    if (rdr["ContactNumber"] != DBNull.Value)
                        objDoctorModel.PhoneNumber = Convert.ToString(rdr["ContactNumber"]);
                    if (rdr["Descriptions"] != DBNull.Value)
                        objDoctorModel.AboutDoctor = Convert.ToString(rdr["Descriptions"]);
                    if (rdr["Address"] != DBNull.Value)
                        objDoctorModel.Address = Convert.ToString(rdr["Address"]);
                    if (rdr["FrmTime"] != DBNull.Value)
                        objDoctorModel.FrmTime = Convert.ToString(rdr["FrmTime"]);
                    if (rdr["ToTime"] != DBNull.Value)
                        objDoctorModel.ToTime = Convert.ToString(rdr["ToTime"]);
                    if (rdr["UserName"] != DBNull.Value)
                        objDoctorModel.Username = Convert.ToString(rdr["UserName"]);
                    if (rdr["LKValue"] != DBNull.Value)
                        objDoctorModel.Type = Convert.ToString(rdr["LKValue"]);
                    if (rdr["UserCode"] != DBNull.Value)
                        objDoctorModel.UserCode = Convert.ToString(rdr["UserCode"]);
                    if (rdr["Password"] != DBNull.Value)
                        objDoctorModel.Password = Convert.ToString(rdr["Password"]);
                    if (rdr["DegreeId"] != DBNull.Value)
                        objDoctorModel.Degree = Convert.ToString(rdr["DegreeId"]);
                    if (rdr["EmailID"] != DBNull.Value)
                        objDoctorModel.EmailId = Convert.ToString(rdr["EmailID"]);


                }
            }
            return objDoctorModel;
        }

        public string UpdateData(DoctorModel objDoctorModel)
        {
            SqlParameter[] param = {
                                     new SqlParameter("@DoctorID",objDoctorModel.DoctorID),
                                      new SqlParameter("@FirstName",objDoctorModel.FirstName),
                                       new SqlParameter("@LastName",objDoctorModel.LastName),
                                        new SqlParameter("@Gender",objDoctorModel.Gender),
                                         new SqlParameter("@Age",objDoctorModel.Age),
                                          new SqlParameter("@EmailId",objDoctorModel.EmailId),
                                           new SqlParameter("@PhoneNumber",objDoctorModel.PhoneNumber),
                                            new SqlParameter("@AboutDoctor",objDoctorModel.AboutDoctor),
                                          new SqlParameter("@FrmTime",objDoctorModel.@FrmTime),
                                         new SqlParameter("@ToTime",objDoctorModel.ToTime),
                                          new SqlParameter("@Username",objDoctorModel.Username),
                                           new SqlParameter("@UserCode",objDoctorModel.UserCode),
                                            new SqlParameter("@Degree",objDoctorModel.Degree),
                                            new SqlParameter("@Address",objDoctorModel.Address),
                                            new SqlParameter("@Status",SqlDbType.VarChar,50){Direction=ParameterDirection.Output}
                                 };
            return SQLHelper.ExecuteNonQueryOutputResult(SQLHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, DBConstants.PRC_UPDATE_DOCTOR, "@STATUS", param);
        }

        public string InsertDoctor(DoctorModel objDoctorModel) 
        {
            SqlParameter[] param = {
                                      new SqlParameter("@FirstName",objDoctorModel.FirstName),
                                       new SqlParameter("@LastName",objDoctorModel.LastName),
                                        new SqlParameter("@Gender",objDoctorModel.Gender),
                                         new SqlParameter("@Age",objDoctorModel.Age),
                                          new SqlParameter("@EmailId",objDoctorModel.EmailId),
                                           new SqlParameter("@PhoneNumber",objDoctorModel.PhoneNumber),
                                         new SqlParameter("@Address",objDoctorModel.Address),
                                          new SqlParameter("@AboutDoctor",objDoctorModel.AboutDoctor),
                                           new SqlParameter("@FrmTime",objDoctorModel.FrmTime),
                                            new SqlParameter("@ToTime",objDoctorModel.ToTime),
                                            new SqlParameter("@Username",objDoctorModel.Username),
                                           new SqlParameter("@UserCode",objDoctorModel.UserCode),
                                            new SqlParameter("@Degree",objDoctorModel.Degree),
                                             new SqlParameter("@DOB",objDoctorModel.DOB),
                                            new SqlParameter("@Password",objDoctorModel.Password),
                                            new SqlParameter("@Status",SqlDbType.VarChar,50){Direction=ParameterDirection.Output}
                                 };
            return SQLHelper.ExecuteNonQueryOutputResult(SQLHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, DBConstants.PRC_INSERT_DOCTOR, "@STATUS", param);
        
        }
    }
}
