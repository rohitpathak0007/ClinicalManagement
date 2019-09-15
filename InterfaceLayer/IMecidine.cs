using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLayer
{
   
   public interface IMecidine
   {
       List<MecidineModel> GetMecidineDetail(UserModel objUserModel);
       MecidineModel GetByID(Int64 ID, string Cmd);
       string UpdateData(MecidineModel objMecidineModel);
       string DeleteData(int ID);
   }
}
