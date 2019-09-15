using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Web;

namespace CommonUtility
{
    public static class ClsIPAddress
    {
        #region Find Current User IP Address

        public static string GetIPAddress()
        {
            //Get IP Address
            string ipaddress = string.Empty;
            try
            {
                if (HttpContext.Current != null)
                {
                    var request = HttpContext.Current.Request;
                    ipaddress = request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                    if (ipaddress == "" || ipaddress == null)
                        ipaddress = request.ServerVariables["REMOTE_ADDR"];
                }
            }
            catch (Exception)
            {

                throw;
            }


            return ipaddress;
        }

        #region FindWorkingIP

        //private static bool FindWorkingIP(IPAddress objIP)
        //{
        //    try
        //    {
        //        if (objIP.Address == null)
        //        {
        //            return false;
        //        }
        //        else
        //        {
        //            return true;
        //        }
        //    }
        //    catch (SocketException)
        //    {
        //        return false;
        //    }
        //}

        #endregion

        #endregion
    }
}
