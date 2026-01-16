using System;
using System.Threading.Tasks.Dataflow;
using System.Text.RegularExpressions;
public abstract class Consultant
{
    public abstract void CalculateGrossPayout();
}
public class Health : Consultant
{
    public string ConsultantId { get; set; }
    public char ConsultantType { get; set; }
    public double StipendAmount { get; set; }
    public double GrossPayout { get; set; }
    public int Tds { get; set; }
    public double NetPayout { get; set; }
    public override void CalculateGrossPayout()
    {
        NetPayout = GrossPayout - (GrossPayout*Tds/100);   
    }
    public void DisplayDetails()
    {
        Console.WriteLine($"Gross: {GrossPayout}");
        Console.WriteLine($"Tds Applied: {Tds}%");
        Console.WriteLine($"Net Payout: {NetPayout}");
    }
}
public class Program
{
    public static void Main()
    {
        Console.Write("Enter Consultant Id: ");
        string ConsultantId = Console.ReadLine();
        if (!validConsultantId(ConsultantId))
        {
            Console.WriteLine("Invalid Doctor Id");
            return;
        }
        Console.Write("Enter House/Visiting Consultant (H/V): ");
        char ConsultantType = Convert.ToChar(Console.ReadLine().ToUpper());
        Console.Write("Enter Stipend Amount: ");
        double StipendAmount = Convert.ToDouble(Console.ReadLine());
        double GrossPayout = 0;
        int Tds = 0;
        if (ConsultantType == 'H')
        {
            if (StipendAmount < 5000)
            {
                Tds = 5;
            }
            else
            {
                Tds = 15;
            }
            GrossPayout = StipendAmount + 2000+1000;
        }
        else if(ConsultantType == 'V')
        {
            Tds = 10;
            GrossPayout = StipendAmount;
        }
        Health health = new Health()
        {
            ConsultantId = ConsultantId,
            ConsultantType = ConsultantType,
            StipendAmount = StipendAmount,
            GrossPayout = GrossPayout,
            Tds = Tds
        };
        health.CalculateGrossPayout();
        health.DisplayDetails();
    }
    public static bool validConsultantId(string ConsultantId)
    {
        string pattern = @"^DR\d{4}$";
        return Regex.IsMatch(ConsultantId, pattern);
    }
}