using System;
public class Calculator
{
    //method Overloading
    public int Add()   //method with no parameters
    {
        int num1 = 10;
        int num2 = 20;
        return num1 + num2;
    }
    public int Add(int num1, int num2) //method with two parameters
    {
        return num1 + num2;
    }
    public string Add(string str1, string str2) //method with two string parameters
    {
        return str1 + str2;
    }
    public float Add(float num1, float num2) //method with two float parameters
    {
        return num1 + num2;
    }
    
}