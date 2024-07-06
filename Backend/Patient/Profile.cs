using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BackendCS
{
    public class Profile
    {
        private string _loginname;
        private string _password;
        private Patient[] _patients;
        private int _Index;                         //current Patient

        public Profile()
        {
            _patients = new Patient[1];


            // Initialsierung von Patienten
            _patients[0] = new Patient("Elisabeth", "Maier", 79);
            _patients[0].setContactPerson(new ContactPerson("Eduard","Wegele","+14917630548044","ewegele@stud.hs-offenburg.de", new Email()));
        }


        public string sGetLoginname()
        {
            return _loginname;
        }

        public string sGetPassword()
        {
            return _password;
        }

        public void sSetLoginname(string email)
        {
           _loginname = email;
       }

         public void sSetPassword(string password)
         {
           _password = password;
         }

         public Patient GetPatient()
         {
             return _patients[_Index];
         }

        public override string ToString()
        {
            return _loginname;
        }
    }
}
