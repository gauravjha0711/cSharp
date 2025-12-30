using System;
public class Program
{
    public static void Main()
    {
        // Console.WriteLine("Enter a string: ");
        // string temp = Console.ReadLine();
        // Console.WriteLine($"You enter: {temp}");

        // string[] StringArray = new string[5];
        // Console.WriteLine("Enter 5 string: ");
        // for(int i = 0; i < 5; i++)
        // {   
        //     Console.Write($"Enter String at index {i}: ");
        //     StringArray[i] = Console.ReadLine();
        // }
        // Console.WriteLine("All String are: ");
        // for(int i = 0; i < 5; i++)
        // {
        //     Console.WriteLine(StringArray[i]);
        // }


        // int[,] matrix1 = {
        //     {1,2,3},
        //     {4,5,6},
        //     {7,8,9}
        // };
        // int[,] matrix2 = {
        //     {1,2,3},
        //     {4,5,6},
        //     {7,8,9}
        // };
        // Console.WriteLine("Sum of two matrix is: ");
        // for(int i = 0; i < matrix1.GetLength(0); i++)
        // {
        //     for(int j=0; j < matrix1.GetLength(1); j++)
        //     {
        //         Console.Write(matrix1[i,j] + matrix2[i,j] + " ");
        //     }
        //     Console.WriteLine();
        // }



        // int[] array = {1,2,3,4,5,6,7,8,9,10};
        // int Largest = array[0];
        // int smallest = array[0];
        // for(int i = 1; i < array.Length; i++)
        // {
        //     if(array[i] > Largest)
        //     {
        //         Largest = array[i];
        //     }
        //     if(array[i] < smallest)
        //     {
        //         smallest = array[i];
        //     }
        // }
        // Console.WriteLine($"Largest number is: {Largest}");
        // Console.WriteLine($"Smallest number is: {smallest}");


        //multiplication of matrix
        // int[,] matrix1 = {
        //     {1,2,3},
        //     {4,5,6},
        //     {7,8,9}
        // };
        // int[,] matrix2 = {
        //     {1,2,3},
        //     {4,5,6},
        //     {7,8,9}
        // };
        // int[,] result = new int[3,3];
        // for(int i = 0; i < matrix1.GetLength(0); i++)
        // {
        //     for(int j=0; j < matrix2.GetLength(1); j++)
        //     {
        //         result[i,j] = 0;
        //         for(int k=0; k < matrix1.GetLength(1); k++)
        //         {
        //             result[i,j] += matrix1[i,k] * matrix2[k,j];
        //         }
        //     }
        // }
        // Console.WriteLine("Product of two matrices is: ");
        // for(int i = 0; i < result.GetLength(0); i++)
        // {
        //     for(int j = 0; j < result.GetLength(1); j++)
        //     {
        //         Console.Write(result[i,j] + " ");
        //     }
        //     Console.WriteLine();
        // }



        // transpose of matrix
        // int[,] matrix = {
        //     {1,2,3},
        //     {4,5,6},
        //     {7,8,9}
        // };
        // for(int i = 0; i < matrix.GetLength(0); i++)
        // {
        //     for(int j = 0; j < i; j++)
        //     {
        //         int temp = matrix[i,j];
        //         matrix[i,j] = matrix[j,i];
        //         matrix[j,i] = temp;
        //     }
        // }
        // Console.WriteLine("Transpose of the matrix is: ");
        // for(int i = 0; i < matrix.GetLength(0); i++)
        // {
        //     for(int j = 0; j < matrix.GetLength(1); j++)
        //     {
        //         Console.Write(matrix[i,j] + " ");
        //     }
        //     Console.WriteLine();
        // }



        //check diagonal matrix
        // int[,] matrix = {
        //     {1,0,0},
        //     {0,5,0},
        //     {0,0,9}
        // };
        // bool isDiagonal = true;
        // for(int i = 0; i < matrix.GetLength(0); i++)
        // {
        //     for(int j = 0; j < matrix.GetLength(1); j++)
        //     {
        //         if(i != j && matrix[i,j] != 0)
        //         {
        //             isDiagonal = false;
        //             break;
        //         }
        //     }
        // }
        // Console.WriteLine("Is the matrix diagonal? " + isDiagonal);



        //reverse string using function
        // Console.WriteLine("Enter a string to reverse: ");
        // string input = Console.ReadLine();
        // char[] charArray = input.ToCharArray();
        // Array.Reverse(charArray);
        // string reversed = new string(charArray);
        // Console.WriteLine($"Reversed string: {reversed}");


        //convert lower to upper case
        // Console.WriteLine("Enter lower case string: ");
        // string lowerCaseInput = Console.ReadLine();
        // string upperCaseOutput = lowerCaseInput.ToUpper();
        // Console.WriteLine($"Upper case string: {upperCaseOutput}");

        //convert upper to lower case
        // Console.WriteLine("Enter upper case string: ");
        // string upperCaseInput = Console.ReadLine();
        // string lowerCaseOutput = upperCaseInput.ToLower();
        // Console.WriteLine($"Lower case string: {lowerCaseOutput}");



        //convert lower to upper case without function
        // Console.WriteLine("Enter lower case string: ");
        // string lowerCaseInput = Console.ReadLine();
        // char[] upperCharArray = new char[lowerCaseInput.Length];
        // for(int i = 0; i < lowerCaseInput.Length; i++)
        // {
        //     upperCharArray[i] = (char)(lowerCaseInput[i] - 32);
        // }
        // string upperCaseOutput = new string(upperCharArray);
        // Console.WriteLine($"Upper case string without function: {upperCaseOutput}");

        //convert upper to lower case without function
        // Console.WriteLine("Enter upper case string: ");
        // string upperCaseInput = Console.ReadLine();
        // char[] lowerCharArray = new char[upperCaseInput.Length];
        // for(int i = 0; i < upperCaseInput.Length; i++)
        // {
        //     lowerCharArray[i] = (char)(upperCaseInput[i] + 32);
        // }
        // string lowerCaseOutput = new string(lowerCharArray);
        // Console.WriteLine($"Lower case string without function: {lowerCaseOutput}");


        //compare two string
        // Console.WriteLine("Enter first string: ");
        // string firstString = Console.ReadLine();
        // Console.WriteLine("Enter second string: ");
        // string secondString = Console.ReadLine();
        // if(firstString.CompareTo(secondString) == 0)
        // {
        //     Console.WriteLine("Both strings are equal.");
        // }
        // else
        // {
        //     Console.WriteLine("Strings are not equal.");
        // }


        //compare two string without function
        // Console.WriteLine("Enter first string: ");
        // string firstString = Console.ReadLine();
        // Console.WriteLine("Enter second string: ");
        // string secondString = Console.ReadLine();
        // bool areEqual = true;
        // if(firstString.Length != secondString.Length)
        // {
        //     areEqual = false;
        // }
        // else
        // {
        //     for(int i = 0; i < firstString.Length; i++)
        //     {
        //         if(firstString[i] != secondString[i])
        //         {
        //             areEqual = false;
        //             break;
        //         }
        //     }
        // }
        // if(areEqual)
        // {
        //     Console.WriteLine("Both strings are equal without using function.");
        // }
        // else
        // {
        //     Console.WriteLine("Strings are not equal without using function.");
        // }



        //concatenate two string with function
        // Console.WriteLine("Enter first string: ");
        // string firstString = Console.ReadLine();
        // Console.WriteLine("Enter second string: ");
        // string secondString = Console.ReadLine();
        // string concatenatedString = String.Concat(firstString, secondString);
        // Console.WriteLine($"Concatenated string: {concatenatedString}");


        //concatenate two string without function
        // Console.WriteLine("Enter first string: ");
        // string firstString = Console.ReadLine();
        // Console.WriteLine("Enter second string: ");
        // string secondString = Console.ReadLine();
        // char[] concatenatedCharArray = new char[firstString.Length + secondString.Length];
        // for(int i = 0; i < firstString.Length; i++)
        // {
        //     concatenatedCharArray[i] = firstString[i];
        // }
        // for(int j = 0; j < secondString.Length; j++)
        // {
        //     concatenatedCharArray[firstString.Length + j] = secondString[j];
        // }
        // string concatenatedString = new string(concatenatedCharArray);
        // Console.WriteLine($"Concatenated string without function: {concatenatedString}");



        //search a string in main string
        Console.WriteLine("Enter main string: ");
        string mainString = Console.ReadLine();
        Console.WriteLine("Enter substring to search: ");
        string subString = Console.ReadLine();
        if(mainString.Contains(subString))
        {
            Console.WriteLine($"The main string contains the substring '{subString}'.");
        }
        else
        {
            Console.WriteLine($"The main string does not contain the substring '{subString}'.");
        }
    }
}