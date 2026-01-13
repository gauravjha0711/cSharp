using System.Data;
public class Employees : DataTable
{
    public Employees()
    {
        this.Columns.Add("Id", typeof(int));
        this.Columns.Add("Name", typeof(string));
        this.Columns.Add("Age", typeof(int));
        this.Columns.Add("Department", typeof(string));
        this.Columns.Add("Salary", typeof(double));
    }
}