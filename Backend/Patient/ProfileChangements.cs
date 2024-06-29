using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BackendCS
{
   public class ProfileChangements
   {
      public int LogIn(string email, string password)
      {
         if (emailAlreadyExisting(email))
         {
            if (correctPassword(email, password))
            {
               setProfile(email, password);
               return 0;
            }
            return 1;
         }
         return 2;
      }

      public bool SignIn(string email, string password)
      {
         if (emailAlreadyExisting(email))
         {
            return false;
         }
         //neuer User
         Dictionary<string, string> users = getUsers();
         users.Add(email, password);
         saveNewUsers(users);

         setProfile(email, password);

         return true;
      }


      private void setProfile(string email, string password)
      {
         Profile.sSetPassword(password);
         Profile.sSetLoginname(email);
      }



      private static bool emailAlreadyExisting(string email)
      {
         return (getUsers().ContainsKey(email));
      }



      private static bool correctPassword(string email, string password)
      {
         return (getUsers()[email] == password);
      }



      public static Dictionary<string, string> getUsers()
      {
         // Load the JSON string from the settings file
         string jsonDic = Properties.Settings.Default.Users;

         // Deserialize the JSON string back to a dictionary
         Dictionary<string, string> users = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonDic);
         if (users == null)
         {
            users = new Dictionary<string, string>();
         }
         return users;
      }


      private static void saveNewUsers(Dictionary<string, string> users)
      {
         // Serialize the dictionary to a JSON string
         string jsonDic = JsonConvert.SerializeObject(users);

         // Save the JSON string to the settings file
         Properties.Settings.Default.Users = jsonDic;
         Properties.Settings.Default.Save();
      }
   }
}
