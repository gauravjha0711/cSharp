using System;
namespace PartialDemo
{
    public partial class PartialEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public string Gender { get; set; }
        public partial void PartialMethod();  //partial method declaration
    }
}