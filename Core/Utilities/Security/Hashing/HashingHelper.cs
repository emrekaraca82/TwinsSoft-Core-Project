using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        //Burada Oluşturduğumuz Password(şifreyi) Hash oluşturuyor
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        //Burada Sonradan sisteme girmek isteyen kişinin verdiği password(şifreyi) db'deki eşlesip eşlesmediğini sorgular
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {               
               var comptedHash =  hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < comptedHash.Length; i++)
                {
                    if (comptedHash[i]!= passwordHash[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

    }
}
