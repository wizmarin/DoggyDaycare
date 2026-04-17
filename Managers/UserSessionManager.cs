using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoggyDaycare.Exceptions;

namespace DoggyDaycare.Services
{
    public class UserSessionManager
    {
        private static UserSessionManager? _instance;
        private static string? _currentUser;

        internal bool isLoggedIn { get; set; } = false;
        internal bool isLoginInProgress { get; set; } = true;

        private UserSessionManager() { }

        public static UserSessionManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new UserSessionManager();
            }

            return _instance;
        }

        public string? GetCurrentUser()
        {
            return _currentUser;
        }

        public void AuthenticateUser(string username, string password)
        {
            if (!IsValidUser(username))
            {
                throw new UserNotFoundException();
            }
            else if (!IsValidPassword(username, password))
            {
                throw new PasswordMismatchException();
            }
            
            _currentUser = username;
        }

        private bool IsValidUser(string username)
        { 
            var users = (System.Collections.Specialized.NameValueCollection)ConfigurationManager.GetSection("users");

            foreach (string user in users){
                
                if (username == users[user])
                {
                    return true;
                }

            }

            return false;
        }

        private bool IsValidPassword(string username, string password)
        {
            var creds = (System.Collections.Specialized.NameValueCollection)ConfigurationManager.GetSection("usersCreds");

            if (password == creds[username])
            {
                return true;
            }

            return false;
        }
    }
}
