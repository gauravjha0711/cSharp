using System;
public class Calculator
{
    public void Addition(int n1, int n2, out int res, out int n3, out int n4)
    {
        res = n1 + n2;
        n3 = n1;
        n4 = n2;
    }
}