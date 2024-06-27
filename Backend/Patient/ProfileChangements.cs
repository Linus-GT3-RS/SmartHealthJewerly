using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCS
{
   public class ProfileChangements
   {
      private List<Profile> _profiles = new List<Profile>();

      public bool LogIn(string email, string password)
      {
            foreach (var profiles in _profiles)
            {
                if (profiles.sGetLoginname() == email && profiles.sGetPassword() == password)
                {
                    return true;
                }
            }
            return false;
      }

      public bool SignUp(string email, string password)
      {
         foreach(var profiles in _profiles)
         {
            if(profiles.sGetLoginname() == email)
            {
                return false;
            }
         }
         _profiles.Add(new Profile(email, password, new List<Patient>()));
         return true;
      }
   }
}
