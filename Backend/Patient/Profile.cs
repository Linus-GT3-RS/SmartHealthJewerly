using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BackendCS
{
    public static class Profile
    {
        private static string _loginname;
        private static string _password;


        public static string sGetLoginname()
        {
            return _loginname;
        }

        public static string sGetPassword()
        {
            return _password;
        }

        public static void sSetLoginname(string email)
        {
           _loginname = email;
       }

         public static void sSetPassword(string password)
         {
           _password = password;
         }
   }
}
