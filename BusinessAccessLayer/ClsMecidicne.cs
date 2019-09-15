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
    public class ClsMecidicne
    {
        #region Global Declarations

        List<MecidineModel> lstMecidineModel = null;
        MecidineModel objMecidineModel = null;

        #endregion

        public List<MecidineModel> GetMecidineDetail(UserModel objUserModel)
        {
            lstMecidineModel = new List<MecidineModel>();
            SqlParameter[] parameter = { 
                                        new SqlParameter("@UserType",objUserModel.UserTypeValue),
                                        //new SqlParameter("@UserCode",objUserModel.UserCode)
                                     };
            using (SqlDataReader rdr = SQLHelper.ExecuteReader(SQLHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, DBConstants.PRC_GET_MECDINE_DETAILS, parameter))
            {
                while (rdr.Read())
                {
                    objMecidineModel = new MecidineModel();
                    if (rdr["MEDID"] != null)
                        objMecidineModel.MEDID = Convert.ToInt64(rdr["MEDID"]);
                    if (rdr["MEDName"] != null)
                        objMecidineModel.MEDName = Convert.ToString(rdr["MEDName"]);
                    if (rdr["IsAvailable"] != null)
                        objMecidineModel.IsAvailable = Convert.ToString(rdr["IsAvailable"]);
                    if (rdr["Quantity"] != null)
                        objMecidineModel.Quantity = Convert.ToInt32(rdr["Quantity"]);
                    if (rdr["MEDPrice"] != null)
                        objMecidineModel.MEDPrice = Convert.ToDouble(rdr["MEDPrice"]);

                    lstMecidineModel.Add(objMecidineModel);
                }
            }
            return lstMecidineModel;
        }



        public MecidineModel GetByID(Int64 ID, string Cmd)
        {
            SqlParameter[] parameter = { 
                                        new SqlParameter("@ID",ID),
                                        new SqlParameter("@CMD",Cmd)
                                     };
            using (SqlDataReader rdr = SQLHelper.ExecuteReader(SQLHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, DBConstants.PRC_GETBYID, parameter))
            {

                objMecidineModel = new MecidineModel();
                while (rdr.Read())
                {

                    if (rdr["MEDID"] != null)
                        objMecidineModel.MEDID = Convert.ToInt64(rdr["MEDID"]);
                    if (rdr["MEDName"] != null)
                        objMecidineModel.MEDName = Convert.ToString(rdr["MEDName"]);
                    if (rdr["IsAvailable"] != null)
                        objMecidineModel.IsAvailable = Convert.ToString(rdr["IsAvailable"]);
                    if (rdr["Quantity"] != null)
                        objMecidineModel.Quantity = Convert.ToInt32(rdr["Quantity"]);
                    if (rdr["MEDPrice"] != null)
                        objMecidineModel.MEDPrice = Convert.ToDouble(rdr["MEDPrice"]);

                }
            }
            return objMecidineModel;
        }


        public string UpdateData(MecidineModel objMecidineModel)
        {
            SqlParameter[] param = {
                                     new SqlParameter("@MEDID",objMecidineModel.MEDID),
                                     new SqlParameter("@MEDPrice",objMecidineModel.MEDPrice),
                                     new SqlParameter("@MEDName",objMecidineModel.MEDName),
                                     new SqlParameter("@Quantity",objMecidineModel.Quantity),
                                     new SqlParameter("@IsAvailable",objMecidineModel.IsAvailable),
                                            new SqlParameter("@Status",SqlDbType.VarChar,50){Direction=ParameterDirection.Output}
                                 };
            return SQLHelper.ExecuteNonQueryOutputResult(SQLHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, DBConstants.PRC_UPDATE_Mecdine, "@STATUS", param);
        }

        public string DeleteData(int ID)
        {
            SqlParameter[] param = {
                new SqlParameter("@ID",ID),
                new SqlParameter("@Status",SqlDbType.VarChar,50){Direction=ParameterDirection.Output}
                                };
            return SQLHelper.ExecuteNonQueryOutputResult(SQLHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, DBConstants.PRC_GET_DELETE_Mecdine, "@STATUS", param);

        }
    }
}
