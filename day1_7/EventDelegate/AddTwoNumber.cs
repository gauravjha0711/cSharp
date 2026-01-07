using System;
public class AddTwoNumber
{
    public delegate void dg_OddNumber();  //declare delegate
    public event dg_OddNumber ev_OddNumber;   //declared events
    public void Add()
    {
        int result
        ;
        result = 5+4;
        Console.WriteLine(result.ToString());
        if((result%2 != 0) && (ev_OddNumber != null))
        {
            ev_OddNumber();
        }
    }
}