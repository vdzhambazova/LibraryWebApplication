using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace LibraryWebApplication.Utility
{
    public static class HashingUtility
    {
        private static SHA1CryptoServiceProvider serviceProvider;

        static HashingUtility()
        {
            HashingUtility.serviceProvider = new SHA1CryptoServiceProvider();
        }

        public static string Encrypt(string password)
        {
            byte[] passwordBytes = Encoding.ASCII.GetBytes(password);
            byte[] hashedPasswordBytes = serviceProvider.ComputeHash(passwordBytes);
            string hashedPassword = Encoding.Default.GetString(hashedPasswordBytes);

            return hashedPassword;
        }
    }
}