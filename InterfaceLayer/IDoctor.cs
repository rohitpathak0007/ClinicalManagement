using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace InterfaceLayer
{
    public interface IDoctor
    {
        List<DoctorModel> GetDoctorDetail(UserModel objUserModel);
        DoctorModel GetByID(Int64 ID, string Cmd);
        string UpdateData(DoctorModel objDoctorModel);
        string DeleteData(int ID);
        string InsertDoctor(DoctorModel objDoctorModel);
    }
}
