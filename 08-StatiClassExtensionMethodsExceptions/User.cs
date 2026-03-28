using System;
namespace _08_StatiClassExtensionMethodsExceptions
{
    public class User
    {
        public string Username;
        public string Password;
        public bool IsLocked;
        public int FailedAttempts;

        public User(string username, string password)
        {
            Username = username;
            Password = password;
            IsLocked = false;
            FailedAttempts = 0;
        }
    }
}

