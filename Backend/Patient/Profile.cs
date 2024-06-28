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
        private string _loginname { get; }
        private string _password;
        private List<Patient> _patients;

        private Profile(string loginname, string password, List<Patient> patients)
        {
            _loginname = loginname;
            _password = password;
            _patients = patients;
        }

        public static Profile CreateProfile(string loginname, string password, List<Patient> patients)
        {
            return new Profile(loginname,password,patients);
        }

        public static Profile CreateProfile(string loginname, string password)
        {
            return new Profile(loginname, password, new List<Patient>());
        }

        public void AddPatient(Patient patient)
        {
            _patients.Add(patient);
        }

        public bool check(string loginname, string password)
        {
            if (_loginname.Equals(loginname) && _password.Equals(password))
            {
                return true;
            }
            return false;
        }


    }
}
