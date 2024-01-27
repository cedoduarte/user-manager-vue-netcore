using UserManager.Utils;

namespace UserManager.Shared
{
    public class Constants
    {
        public static string GetPasswordError(string name = "password")
        {
            string message = $"The {name} is not valid: The minimum length is " +
                $"{PasswordValidator.MinimumLength}, has at least one upper case " +
                $"letter, has at least one lower case letter, has at least one digit, " +
                $"has at least one special character";
            return message;
        }
    }
}
