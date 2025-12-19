using System;
class Practice
{
    static void Main()
    {   
        // 1)Sample C# program to print a welcome message
        // 2)Write C# program to read a number user and display it */
        // 3)Write C# program to read a floating point number from user 
        // 4)Write C# program to read a string from user and display 
        // it on the screen 
        // 5)Write C# program to perform all arithmetic operations*/
        // 6)Write C# program to find the area of circle */
        // 7) program to find whether the given number is Even or Odd */
        // 8)program to find the greatest of 2 numbers */
        // 9) program to find whether a given number is positive ,negative or zero*/
        // 10 program to find the greatest of three numbers using nested if*/ 
        // 11) program to find the greatest of 3 numbers using conditional operator */


        Console.WriteLine("Hello, from Gaurav Jha");
        // Console.WriteLine("Enter integer number: ");
        // int num = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("You entered: " + num);
        // Console.WriteLine("Enter floating point number: ");
        // float fnum = Convert.ToSingle(Console.ReadLine());
        // Console.WriteLine("You entered: " + fnum);
        // Console.WriteLine("Enter string: ");
        // string temp = Convert.ToString(Console.ReadLine());
        // Console.WriteLine("You entered string: " + temp);

        // Console.WriteLine("Enter radius: ");
        // int radius = Convert.ToInt32(Console.ReadLine());
        // double area = 3.14 * radius * radius;
        // Console.WriteLine("Area of circle is: " + area);

        // Console.WriteLine("Enter number: ");
        // int number = Convert.ToInt32(Console.ReadLine());
        // if(number % 2 == 0)
        // {
        //     Console.WriteLine("The number is even.");
        // }
        // else
        // {
        //     Console.WriteLine("The number is odd.");
        // }

        // Console.WriteLine("Enter first number: ");
        // int num1 = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter second number: ");
        // int num2 = Convert.ToInt32(Console.ReadLine());
        // if(num1 > num2)
        // {
        //     Console.WriteLine("First number is greater.");
        // }
        // else if(num2 > num1)
        // {
        //     Console.WriteLine("Second number is greater.");
        // }
        // else
        // {
        //     Console.WriteLine("Both numbers are equal.");
        // }

        // Console.WriteLine("Enter Number: ");
        // int number = Convert.ToInt32(Console.ReadLine());
        // if(number < 0)
        // {
        //     Console.WriteLine("Negative Number");
        // }
        // else if(number == 0)
        // {
        //     Console.WriteLine("Zero");
        // }
        // else
        // {
        //     Console.WriteLine("Positive Number");
        // }

        // int[] arr = {10, 30, 20};
        // if (arr[0] > arr[1])
        // {
        //     if(arr[0] > arr[2])
        //     {
        //         Console.WriteLine("Largest element is: " + arr[0]);
        //     }
        //     else
        //     {
        //         Console.WriteLine("Largest element is: " + arr[2]);
        //     }
        // }
        // else
        // {
        //     if(arr[1] > arr[2])
        //     {
        //         Console.WriteLine("Largest element is: " + arr[1]);
        //     }
        //     else
        //     {
        //         Console.WriteLine("Largest element is: " + arr[2]);
        //     }
        // }

        // int largest = arr[0];
        // for(int i=1; i<arr.Length; i++)
        // {
        //     if(arr[i] > largest)
        //     {
        //         largest = arr[i];
        //     }
        // }
        // Console.WriteLine("Largest element is: " + largest);



        // 17)Write C#  program to print numbers from 1 to n(user input) using while loop*/
        // 18)Write C#  program to print even numbers from 1 to n(user input) 
        // 19)Write C#  program to find the sum  of numbers from 1 to n (user input) using while loop*/
        // 20)Write C#  program to print multiplication table of given number */
        // 21) Write C#  program to calculate the power of a given number */
        // 22)Write C#  program to generate fibbonacci series(0 1 1 2 3 5 8 13 21 34 55...) upto n(user input)*/
        // 23)Write C#  program to find whether the given number is Armstrong or not
        // 24)program to print armstrong numbers from n1 to n2
        // 25) program to check whether the number is prime or not */


        // Console.WriteLine("Enter value of n : ");
        // int n = Convert.ToInt32(Console.ReadLine());
        // for(int i=1; i<=n; i++)
        // {
        //     Console.WriteLine("Value: " + i);
        // }

        // Console.WriteLine("Enter value of n : ");
        // int n = Convert.ToInt32(Console.ReadLine());
        // for(int i=1; i<=n; i++)
        // {
        //     if(i % 2 == 0)
        //     {
        //         Console.WriteLine("Even Value: " + i);
        //     }
        // }

        // int sum = 0;
        // int i=1;
        // Console.WriteLine("Enter value of n : ");
        // int n = Convert.ToInt32(Console.ReadLine());
        // while (i <= n)
        // {
        //     sum += i;
        //     i++;
        // }
        // Console.WriteLine("Sum of numbers from 1 to n is: " + sum);

        // int mul = 1;
        // int i=1;
        // Console.WriteLine("Enter value of n : ");
        // int n = Convert.ToInt32(Console.ReadLine());
        // while (i <= n)
        // {
        //     mul *= i;
        //     i++;
        // }
        // Console.WriteLine("Product of numbers from 1 to n is: " + mul);

        // Console.WriteLine("Enter base number: ");
        // int baseNum = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter exponent: ");
        // int exponent = Convert.ToInt32(Console.ReadLine());
        // int result = 1;
        // for(int i=1; i<=exponent; i++)
        // {
        //     result = result * baseNum;
        // }
        // Console.WriteLine("Result: " + result);

        // Console.WriteLine("Enter a number for fibonacci : ");
        // int number = Convert.ToInt32(Console.ReadLine());
        // int a = 0, b = 1, c;
        // Console.WriteLine("Fibonacci Series: ");
        // for(int i=0; i<number; i++)
        // {
        //     Console.WriteLine(a);
        //     c = a + b;
        //     a = b;
        //     b = c;
        // }

        // Console.WriteLine("Enter a number to check Armstrong: ");
        // int number = Convert.ToInt32(Console.ReadLine());
        // int originalNumber = number;
        // int sum = 0;
        // while(number != 0)
        // {
        //     int digit = number % 10;
        //     sum += digit * digit * digit;
        //     number /= 10;
        // }
        // if(sum == originalNumber)
        // {
        //     Console.WriteLine("The number is an Armstrong number.");
        // }
        // else
        // {
        //     Console.WriteLine("The number is not an Armstrong number.");
        // }

        // Console.WriteLine("Enter limit n1 for armstrong numbers: ");
        // int n1 = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter limit n2 for armstrong numbers: ");
        // int n2 = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Armstrong numbers between {0} and {1} are: ", n1, n2);
        // for(int num = n1; num <= n2; num++)
        // {
        //     int sum = 0;
        //     int temp = num;
        //     while(temp != 0)
        //     {
        //         int digit = temp % 10;
        //         sum += digit * digit * digit;
        //         temp /= 10;
        //     }
        //     if(sum == num)
        //     {
        //         Console.WriteLine(num);
        //     }
        // }

        // Console.WriteLine("Enter a number to check Prime: ");
        // int number = Convert.ToInt32(Console.ReadLine());
        // bool isPrime = true;
        // for(int i=2; i<=number/2; i++)
        // {
        //     if(number % i == 0)
        //     {
        //         isPrime = false;
        //         break;
        //     }
        // }
        // if(isPrime && number > 1)
        // {
        //     Console.WriteLine("The number is Prime.");
        // }
        // else
        // {
        //     Console.WriteLine("The number is not Prime.");
        // }



        // 12) program to read student num,name,mark of six subject and 
        // calculate total and average and print result and division */

        // Console.WriteLine("Enter Student Number: ");
        // int stuNum = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter Student Name: ");
        // string stuName = Convert.ToString(Console.ReadLine());
        // Console.WriteLine("Enter marks of 6 subjects: ");
        // int totalMarks = 0;
        // for(int i=1; i<=6; i++)
        // {
        //     Console.WriteLine("Enter marks for subject " + i + ": ");
        //     int marks = Convert.ToInt32(Console.ReadLine());
        //     totalMarks += marks;
        // }
        // double averageMarks = totalMarks / 6.0;
        // Console.WriteLine("Total Marks: " + totalMarks);
        // Console.WriteLine("Average Marks: " + averageMarks);


        // 13)/*program to read eno,ename,basic salary and calculate  
        // pf,hra,da,net salary and gross salary and print eno,ename,basic 
        // salary,
        // gross salary and net salary*/
        // pf= 12% of basic salary.
        // hra=20% of basic salary.
        // da= 15% of basic salary.
        // gross salary=pf+hra+da+basic salary;
        // net salary=gross salary - pf;

        // Console.WriteLine("Enter Employee Number: ");
        // int empNum = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter Employee Name: ");
        // string empName = Convert.ToString(Console.ReadLine());
        // Console.WriteLine("Enter Basic Salary: ");
        // double basicSalary = Convert.ToDouble(Console.ReadLine());
        // double pf = 0.12 * basicSalary;
        // double hra = 0.20 * basicSalary;
        // double da = 0.15 * basicSalary;
        // double grossSalary = basicSalary + pf + hra + da;
        // double netSalary = grossSalary - pf;
        // Console.WriteLine("Employee Number: " + empNum);
        // Console.WriteLine("Employee Name: " + empName);
        // Console.WriteLine("Basic Salary: " + basicSalary);
        // Console.WriteLine("Gross Salary: " + grossSalary);
        // Console.WriteLine("Net Salary: " + netSalary);


        // 29)C# Program to Print Odd Numbers in a Given Range
        //     This is a C# Program to generate odd numbers within a range.
        //     Problem Description
        //     This C# Program Generates Odd Numbers within a Range.
        //     Problem Solution
        //     Here Enumerable.Range generates a collection of odd numbers of a specified range.
        //     Runtime Test Cases
        //     21
        //     23
        //     25
        //     27
        //     29
        //     31
        //     33
        //     35
        //     37
        //     39

        // Console.WriteLine("Enter starting number of the range: ");
        // int startRange = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter ending number of the range: ");
        // int endRange = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine($"Odd numbers between {startRange} and {endRange} are:");
        // for(int i = startRange; i <= endRange; i++)
        // {
        //     if(i % 2 != 0)
        //     {
        //         Console.WriteLine(i);
        //     }
        // }


        //30  C# Program to Find the Sum of All the Multiples of 3 and 5
        // This is a C# Program to print the sum of all the multiples of 3 and 5.

        // Problem Description
        // This C# Program Prints the Sum of all the Multiples of 3 and 5.

        // Problem Solution
        // Here the multiples of 3 and 5 are found and the sum of all the multiples are calculated and are displayed.

        // Runtime Test Cases
        
        // 3  5  6  9  10  12  15  18  20  21  24  25  27  30  33  35  36  
        // 39  40  42  45  48 50  51  54  55  57  60  63  65  66  69  70  72  
        // 75  78  80  81  84  85  87  90  93  95  96  99
        // The Sum of all the Multiples of 3 or 5 Below 100 : 2318

        Console.WriteLine("Enter limit number: ");
        int limit = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        Console.WriteLine($"Multiples of 3 or 5 below {limit} are: ");
        for(int i=1; i<limit; i++)
        {
            if(i % 3 == 0 || i % 5 == 0)
            {
                Console.Write(i + "  ");
                sum += i;
            }
        }
        Console.WriteLine($"\nThe Sum of all the Multiples of 3 or 5 Below {limit} : {sum}");
    }
}