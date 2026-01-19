using System;
public class PasswordMismatchException : Exception
{
    public PasswordMismatchException(string message) : base(message){}
}   
public class User
{
    public string Name { get; set; }
    public string Password { get; set; }
    public string ConfirmationPassword { get; set; }
}
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter User Name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Password:");
        string password = Console.ReadLine();
        Console.WriteLine("Enter Confirmation Password:");
        string confirmPassword = Console.ReadLine();
        User user = ValidatePassword(name, password, confirmPassword);
        Console.WriteLine("User authenticated successfully.");
    }
    public static User ValidatePassword(string name, string password, string confirmPassword)
    {
        User user = new User()
        {
            Name = name,
            Password = password,
            ConfirmationPassword = confirmPassword
        };
        if(user.Password == user.ConfirmationPassword)
        {
            return user;
        }
        else
        {
            throw new PasswordMismatchException("Password entered does not match.");
        }
    }
}