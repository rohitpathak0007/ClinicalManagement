using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CommonUtility
{
    #region ClsSecurity

    public static class ClsSecurity
    {
        public static string EncryptPassword(string password)
        {
            Crypt objCrypt = new Crypt();
            return objCrypt.Encrypt(password);
        }

        public static string DecryptPassword(string password)
        {
            Crypt objCrypt = new Crypt();
            return objCrypt.Decrypt(password);
        }

        //------------------------------------------------------
        const string DESKey = "AQWSEDRF";
        const string DESIV = "HGFEDCBA";
        //------------------------------------------------------

        public static string DESDecrypt(string stringToDecrypt)
        {
            byte[] key;
            byte[] IV;
            byte[] inputByteArray;
            try
            {
                key = Convert2ByteArray(DESKey);
                IV = Convert2ByteArray(DESIV);
                int len = stringToDecrypt.Length; inputByteArray = Convert.FromBase64String(stringToDecrypt);
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(key, IV), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                Encoding encoding = Encoding.UTF8; return encoding.GetString(ms.ToArray());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public static string DESEncrypt(string stringToEncrypt)
        {
            byte[] key;
            byte[] IV;
            byte[] inputByteArray;
            try
            {
                key = Convert2ByteArray(DESKey);
                IV = Convert2ByteArray(DESIV);
                inputByteArray = Encoding.UTF8.GetBytes(stringToEncrypt);
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                MemoryStream ms = new MemoryStream(); CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(key, IV), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                return Convert.ToBase64String(ms.ToArray());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        static byte[] Convert2ByteArray(string strInput)
        {
            int intCounter; char[] arrChar;
            arrChar = strInput.ToCharArray();
            byte[] arrByte = new byte[arrChar.Length];
            for (intCounter = 0; intCounter <= arrByte.Length - 1; intCounter++)
                arrByte[intCounter] = Convert.ToByte(arrChar[intCounter]);
            return arrByte;
        }
    }

    #endregion

    #region Crypt

    public class Crypt
    {
        string myKey;
        TripleDESCryptoServiceProvider cryptDES3 = new TripleDESCryptoServiceProvider();
        MD5CryptoServiceProvider cryptMD5Hash = new MD5CryptoServiceProvider();

        public Crypt()
        {
            myKey = "password";// Convert.ToString(ConfigurationManager.AppSettings["DecryptKey"]);            
        }

        public string Decrypt(string myString)
        {
            cryptDES3.Key = cryptMD5Hash.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(myKey));
            cryptDES3.Mode = CipherMode.ECB;
            ICryptoTransform desdencrypt = cryptDES3.CreateDecryptor();
            byte[] buff = new byte[0];
            buff = Convert.FromBase64String(myString);
            return ASCIIEncoding.ASCII.GetString(desdencrypt.TransformFinalBlock(buff, 0, buff.Length));
        }

        public string Encrypt(string myString)
        {
            System.Text.ASCIIEncoding encodingKey = new System.Text.ASCIIEncoding();
            cryptDES3.Key = cryptMD5Hash.ComputeHash(encodingKey.GetBytes(myKey));
            cryptDES3.Mode = CipherMode.ECB;
            ICryptoTransform desdencrypt = cryptDES3.CreateEncryptor();
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            byte[] buff = new byte[0];
            buff = encoding.GetBytes(myString);
            return Convert.ToBase64String(desdencrypt.TransformFinalBlock(buff, 0, buff.Length));
        }
    }

    #endregion
}