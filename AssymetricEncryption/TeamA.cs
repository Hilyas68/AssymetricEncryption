 using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AssymetricEncryption
{
    class TeamA
    {
        static void Main(string[] args)
        {
            #region Authors
             /* Author
             1. Mabi Chuks
             2. Oriahi Emmanuel
             3. Olowoniwa Gabriel
             4. Hassan Temitope
             */
            #endregion

            byte[] data = Encoding.UTF8.GetBytes("This is an encrypted message from Team A ");
            byte[] encryptedData;
           

            using (var rsaSender = new RSACryptoServiceProvider())
            {
                string publicKey = File.ReadAllText("publickey.xml");

                rsaSender.FromXmlString(publicKey);
                encryptedData = rsaSender.Encrypt(data, true);

                File.WriteAllText("encryptedData.xml", Encoding.UTF8.GetString(encryptedData));
            }
            

        }
    }
}
