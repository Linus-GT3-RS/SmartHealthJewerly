using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BackendCS
{
    internal class Profile
    {
        private string _loginname;
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

        public void AddProfile(Patient patient)
        {
            _patients.Add(patient);
        }

    }
}
