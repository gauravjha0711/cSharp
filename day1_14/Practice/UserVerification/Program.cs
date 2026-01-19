using System;
public class InvalidPhoneNumberException : Exception
{
    public InvalidPhoneNumberException(string message) : base(message) { }
}
public class User
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
}
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter User Name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Phone Number:");
        string phoneNumber = Console.ReadLine();
        User user = ValidatePhoneNumber(name, phoneNumber);
        Console.WriteLine("User verified successfully.");
    }
    public static User ValidatePhoneNumber(string name, string phoneNumber)
    {
        if(phoneNumber.Length == 10)
        {
            User user = new User()
            {
                Name = name,
                PhoneNumber = phoneNumber
            };
            return user;
        }
        else
        {
            throw new InvalidPhoneNumberException("Invalid Phone Number");
        }
    }
}