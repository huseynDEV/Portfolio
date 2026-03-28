// See https://aka.ms/new-console-template for more information
using System;
using _08_StatiClassExtensionMethodsExceptions;

class Program
{
    static void Main()
    {
        LoginSystem sys = new LoginSystem();

        while (true)
        {
            try
            {
                Console.Write("Username: ");
                string u = Console.ReadLine();

                Console.Write("Password: ");
                string p = Console.ReadLine();

                if (sys.Login(u, p)) break;
            }
            catch (InvalidUsernameException e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }
            catch (InvalidPasswordException e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }
            catch (UserNotFoundException e)
            {
                Console.WriteLine("ERROR: " + e.Message);
                sys.ShowUsers();
            }
            catch (IncorrectPasswordException e)
            {
                Console.WriteLine("WARNING: " + e.Message);
            }
            catch (AccountLockedException e)
            {
                Console.WriteLine("CRITICAL: " + e.Message);
                break;
            }
        }
    }
}
