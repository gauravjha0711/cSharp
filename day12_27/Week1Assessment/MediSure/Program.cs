using System;
public class Program
{
    public static void Main()
    {
        Patientbill bill = new Patientbill();
        while (true)
        {
            Console.WriteLine("----- MediSure Clinic Billing -----");
            Console.WriteLine("1. Create New Bill (Enter Patient Details)");
            Console.WriteLine("2. View Last Bill");
            Console.WriteLine("3. Clear Last Bill");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your option: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    bill.CreateNewBill();
                    break;
                case 2:
                    bill.ViewLastBill();
                    break;
                case 3:
                    bill.ClearLastBill();
                    break;
                case 4:
                    Console.WriteLine("Thank You. Application Closed normally.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}