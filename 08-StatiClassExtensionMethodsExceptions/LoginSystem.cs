using System;
namespace _08_StatiClassExtensionMethodsExceptions
{
    using System;

    public class LoginSystem
    {
        private User[] users =
        {
        new User("huseyn","huseyn123"),
        new User("feyzullah","feyzullah123"),
        new User("hesen","hesen123")
    };

        private const int MaxAttempts = 3;

        private User FindUser(string username)
        {
            foreach (User u in users)
                if (u.Username.ToLower() == username.ToLower())
                    return u;

            return null;
        }

        public bool Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || username.Length < 3)
                throw new InvalidUsernameException();

            if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
                throw new InvalidPasswordException();

            User user = FindUser(username);

            if (user == null)
                throw new UserNotFoundException(username);

            if (user.IsLocked)
                throw new AccountLockedException();

            if (user.Password == password)
            {
                user.FailedAttempts = 0;
                Console.WriteLine($"Login successful! Welcome, {username}!");
                return true;
            }

            int left = MaxAttempts - ++user.FailedAttempts;

            if (left <= 0)
            {
                user.IsLocked = true;
                throw new AccountLockedException();
            }

            throw new IncorrectPasswordException(left);
        }

        public void ShowUsers()
        {
            Console.WriteLine("Mövcud istifadəçilər:");
            foreach (User u in users)
                Console.WriteLine(u.Username);
        }
    }
}

