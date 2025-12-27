using System;
using System.Reflection.Metadata;
public class Patientbill
{
    public string BillId { get; set; }
    public string PatientName { get; set; }
    public bool HasInsurance { get; set; }
    public double ConsultationFee { get; set; }
    public double LabCharges { get; set; }
    public double MedicineCharges { get; set; }
    public double GrossAmount { get; set; }
    public double DiscountAmount { get; set; }
    public double FinalPayable {get; set; }
    public static double PatientBill { get; set; }
    public static double LastBill { get; set; }
    public static bool HasLastBill { get; set; }
    public void CreateNewBill()
    {
        Console.Write("Enter Bill ID: ");
        BillId = Console.ReadLine();
        Console.Write("Enter Patient Name: ");
        PatientName = Console.ReadLine();
        Console.Write("Is the patient insured? (yes/no): ");
        string insuranceInput = Console.ReadLine().ToLower();
        HasInsurance = insuranceInput == "yes";
        Console.Write("Enter Consultation Fee: ");
        ConsultationFee = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Lab Charges: ");
        LabCharges = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Medicine Charges: ");
        MedicineCharges = Convert.ToDouble(Console.ReadLine());

        GrossAmount = ConsultationFee + LabCharges + MedicineCharges;
        DiscountAmount = HasInsurance ? GrossAmount * 0.1 : 0;
        FinalPayable = GrossAmount - DiscountAmount;

        LastBill = FinalPayable;
        HasLastBill = true;

        Console.WriteLine("New bill created successfully.");
    }
    public void ViewLastBill()
    {
        if (!HasLastBill)
        {
            Console.WriteLine("No bill available to display.");
            return;
        }

        Console.WriteLine("----- Last Patient Bill -----");
        Console.WriteLine($"BillID: {BillId}");
        Console.WriteLine($"Patient Name: {PatientName}");
        Console.WriteLine($"Insured: {(HasInsurance ? "Yes" : "No")}");
        Console.WriteLine($"Consultation Fee: {ConsultationFee}");
        Console.WriteLine($"Lab Charges: {LabCharges}");
        Console.WriteLine($"Medicine Charges: {MedicineCharges}");
        Console.WriteLine($"Gross Amount: {GrossAmount}");
        Console.WriteLine($"Discount Amount: {DiscountAmount}");
        Console.WriteLine($"Final Payable Amount: {FinalPayable}");
        Console.WriteLine("------------------------------");
    }
    public void ClearLastBill()
    {
        if (!HasLastBill)
        {
            Console.WriteLine("No bill available to clear.");
            return;
        }

        BillId = null;
        PatientName = null;
        HasInsurance = false;
        ConsultationFee = 0;
        LabCharges = 0;
        MedicineCharges = 0;
        GrossAmount = 0;
        DiscountAmount = 0;
        FinalPayable = 0;

        HasLastBill = false;
        LastBill = 0;

        Console.WriteLine("Last bill cleared successfully.");
    }
}