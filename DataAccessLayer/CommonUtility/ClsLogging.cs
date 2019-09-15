using System;
using System.Configuration;
using System.IO;

namespace CommonUtility
{
    public class ClsLogging
    {
        #region Log Type

        public enum LogType
        {
            CL_Exception
        }

        #endregion

        #region Logging Region

        public static void writefile(string msg, LogType ProcessType)
        {
            string Islogging = ConfigurationManager.AppSettings["Islogging"];
            if (Islogging != "Y")
            {
                return;
            }
            string LogFilePath = ConfigurationManager.AppSettings["LogFilePath"];
            try
            {
                if (!System.IO.Directory.Exists(LogFilePath))
                {
                    System.IO.Directory.CreateDirectory(LogFilePath);
                }
                string dt = DateTime.Now.ToString("dd/MM/yyyy");
                string dd = dt.Substring(0, 2);
                string mm = dt.Substring(3, 2);
                string yy = dt.Substring(6, 4);
                string errdt = dd + mm + yy;
                string strLogPath = LogFilePath + errdt + "\\";
                if (!Directory.Exists(strLogPath))
                {
                    Directory.CreateDirectory(strLogPath);
                }
                FileStream fs = new FileStream(strLogPath + ProcessType + ".txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter m_sr = new StreamWriter(fs);
                m_sr.BaseStream.Seek(0, SeekOrigin.End);
                m_sr.WriteLine("[" + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss:fff tt") + "]  \t" + msg);
                m_sr.Flush();
                m_sr.Close();
                fs.Dispose();
            }
            catch (Exception)
            {

            }
        }

        #endregion
    }
}