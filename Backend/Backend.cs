using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using BackendCS;

namespace BackendCS
{

    public class Backend
    {
        private static Profile[] _profiles;
        private static Backend _instance;

        private static void Initialize()
        {
            
            _profiles =  new Profile[1];


            // Here you can add new profiles manually
            _profiles[0] = Profile.CreateProfile("admin", "admin123");

        }
        

        public static Backend Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Backend();
                }

                return _instance;
            }
        }

        public static bool Login(string username, string password)
        {
            if (_profiles == null)
            {
                Initialize();
            }
            for (int i = 0; i < _profiles.Length; i++)
            {
                if (_profiles[i].check(username, password))
                {
                    return true;
                }
            }

            return false;
        }

    }
}