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
        Console.Write("Enter Bill Id: ");
        BillId = Console.ReadLine();
        Console.Write("Enter Patient Name: ");
        PatientName = Console.ReadLine();
        Console.Write("Is the Patient insured? (Y/N): ");
        string insuranceInput = Console.ReadLine().ToUpper();
        HasInsurance = insuranceInput == "Y";
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

        Console.WriteLine("New bill created.");
    }
    public void ViewLastBill()
    {
        if (!HasLastBill)
        {
            Console.WriteLine("No bill available to Show.");
            return;
        }

        Console.WriteLine("----- Last Patient Bill -----");
        Console.WriteLine($"Bill Id: {BillId}");
        Console.WriteLine($"Patient Name: {PatientName}");
        Console.WriteLine($"Insured: {(HasInsurance ? "Yes" : "No")}");
        Console.WriteLine($"Consultation Fee: {Math.Round(ConsultationFee, 2)}");
        Console.WriteLine($"Lab Charges: {Math.Round(LabCharges, 2)}");
        Console.WriteLine($"Medicine Charges: {Math.Round(MedicineCharges, 2)}");
        Console.WriteLine($"Gross Amount: {Math.Round(GrossAmount, 2)}");
        Console.WriteLine($"Discount Amount: {Math.Round(DiscountAmount, 2)}");
        Console.WriteLine($"Final Payable Amount: {Math.Round(FinalPayable, 2)}");
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

        Console.WriteLine("Last bill cleared.");
    }
}