using System;
[AttributeUsage(
    AttributeTargets.Class | 
    AttributeTargets.Method |
    AttributeTargets.Constructor |
    AttributeTargets.Field |
    AttributeTargets.Property,
    AllowMultiple = true)
]
public class DeBugInfo : Attribute
{
    public int BugNo { get; }
    public string Developer { get; }
    public string LastReview { get; set; }
    public string Message { get; set; }
    public DeBugInfo(int bg, string dev, string d)
    {
        this.BugNo = bg;
        this.Developer = dev;
        this.LastReview = d;
    }
    
}