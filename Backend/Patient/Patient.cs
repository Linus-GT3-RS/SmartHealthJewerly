using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCS
{
    public class Patient
    {
        private string _firstname;
        private string _lastname;
        private int _age;
        private List<ContactPerson> _contacts;
        private HealthData _healthData;

        Patient(string firstname, string lastname, int age, List<ContactPerson> contact, HealthData healthData)
        {
                _firstname = firstname;
                _lastname = lastname;
                _age = age;
                _contacts = contact;
                _healthData = healthData;
        }

        public void setContactPerson(ContactPerson contact)
        {
            _contacts.Add(contact);
        }
    }
}
