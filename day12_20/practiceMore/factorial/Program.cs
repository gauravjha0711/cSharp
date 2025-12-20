using System;
public class Program
{
    //factorial Program
    static void Main()
    {
        string number="";
        string[] ans = new string[10];  
        int index = 0;
        while(true)
        {
            Console.WriteLine("Enter positive integer to calculate factorial: ");
            number = (Console.ReadLine());
            if(number[0]=='q') break;
            if(number[0]!='q' && number[0]>='a' && number[0] <= 'z')
            {
                string temp = "Factorial of " + number + " is invalid input";
                ans[index] = temp;
                index++;
                continue;
            }
            int num = Convert.ToInt32(number);
            if(num<0)
            {
                string temp1 = "Factorial of " + number + " is invalid input";
                ans[index] = temp1;
                index++;
                continue;
            }
            int fact = 1;
            for(int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            string temp2 = "Factorial of " + number + " is " + fact;;
            ans[index] = temp2;
            index++;
        }
        Console.WriteLine("Results:");
        for(int i=0;i<index;i++){
            Console.WriteLine(ans[i]);
        }
    }
}