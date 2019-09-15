using System;
using System.Collections.Generic;
using Model;

namespace InterfaceLayer
{
    public interface ICustomer
    {
        string InsertAppointment(CustomerModel objCustomerModel);
        UserModel isValidUser(UserModel objUserModel);
        List<CustomerModel> GetCustomerDetail(UserModel objUserModel);
        CustomerModel GetByID(Int64 ID, string Cmd);
        string UpdateData(CustomerModel objCustomerModel);
        string DeleteData(int ID);
        List<DropDown> GetDropDown(string CMD);
        string InsertCustomer(CustomerModel objCustomerModel);
    }
}
