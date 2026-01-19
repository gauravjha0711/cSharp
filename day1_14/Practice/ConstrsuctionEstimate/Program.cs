using System;
public class ConstructionEstimateException : Exception
{
    public ConstructionEstimateException(string message) : base(message) { }
}
public class EstimateDetails
{
    public float ConstructionArea { get; set; }
    public float SiteArea { get; set; }
}
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter Construction Area:");
        float constructionArea = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter Site Area:");
        float siteArea = float.Parse(Console.ReadLine());
        EstimateDetails estimateDetails = ValidateConstructionEstimate(constructionArea, siteArea);
        Console.WriteLine("Construction Estimate approved successfully.");
    }
    public static EstimateDetails ValidateConstructionEstimate(float ConstructionArea, float SiteArea)
    {
        if (ConstructionArea < SiteArea)
        {
            EstimateDetails estimateDetails = new EstimateDetails()
            {
                ConstructionArea = ConstructionArea,
                SiteArea = SiteArea
            };
            return estimateDetails;
        }
        else
        {
            throw new ConstructionEstimateException("Sorry Construction Estimate is not approved.");
        }
    }
}