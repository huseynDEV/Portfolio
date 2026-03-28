using System;
namespace _08_StatiClassExtensionMethodsExceptions
{
    using System;

    public class InvalidUsernameException : Exception
    {
        public InvalidUsernameException(string msg = "Username səhvdir") : base(msg) { }
    }

    public class InvalidPasswordException : Exception
    {
        public InvalidPasswordException(string msg = "Password səhvdir") : base(msg) { }
    }

    public class UserNotFoundException : Exception
    {
        public UserNotFoundException(string username)
            : base($"User '{username}' tapılmadı") { }
    }

    public class IncorrectPasswordException : Exception
    {
        public int AttemptsLeft;

        public IncorrectPasswordException(int left)
            : base($"Şifrə səhvdir! Qalan: {left}")
        {
            AttemptsLeft = left;
        }
    }

    public class AccountLockedException : Exception
    {
        public AccountLockedException() : base("Hesab bloklanıb") { }
    }
}

