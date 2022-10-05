using System.Security.Cryptography;
using System.Text;

namespace Prelab
{
    public class HashPass
    {
      //  public StringBuilder sb = new StringBuilder();

        public string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        /// <summary>
        /// This function cyrpts given string.
        /// </summary>
        /// <param name="password"></param>
        //public void MD5Cyrpt(ref string password)
        //{
        //    MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

        //    byte[] dizi = Encoding.UTF8.GetBytes(password);

        //    dizi = md5.ComputeHash(dizi);

        //    foreach (byte ba in dizi)
        //    {
        //        sb.Append(ba.ToString("x2").ToLower());
        //    }
        //    password = sb.ToString();
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <returns>Cyrpted string</returns>
        //public string getPass()
        //{
        //    return sb.ToString();
        //}
    }
}