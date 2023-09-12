using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP2_Garcia
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create a program that first accept two numbers, then display the sum, difference, product, quotient of the 2 numbers. 
             After displaying the result, the program will then ask the user to enter another 6 numbers, then compute for the average of it*/

            int firstVal, secVal, a1, a2, a3, a4, a5, a6;

            //input for the first part of the program

            Console.Write("Input the first number: ");
            firstVal = Int32.Parse(Console.ReadLine());
            Console.Write("Input the second number: ");
            secVal = Int32.Parse(Console.ReadLine());

            //operations

            int sum = firstVal + secVal;
            int difference = firstVal - secVal;
            int product = firstVal * secVal;
            float quotient = (float)firstVal / (float)secVal;

            //print

            Console.WriteLine("The sum of " + firstVal + " and " + secVal + " is: " + sum);
            Console.WriteLine("The difference of " + firstVal + " and " + secVal + " is: " + difference);
            Console.WriteLine("The product of " + firstVal + " and " + secVal + " is: " + product);
            Console.WriteLine("The quotient of " + firstVal + " and " + secVal + " is: " + quotient);

            //second part of the program
            //input for the average

            Console.WriteLine("\nInput 6 numbers to compute the average");
            Console.Write("Input the first number: ");
            a1 = Int32.Parse(Console.ReadLine());
            Console.Write("Input the second number: ");
            a2 = Int32.Parse(Console.ReadLine());
            Console.Write("Input the third number: ");
            a3 = Int32.Parse(Console.ReadLine());
            Console.Write("Input the fourth number: ");
            a4 = Int32.Parse(Console.ReadLine());
            Console.Write("Input the fifth number: ");
            a5 = Int32.Parse(Console.ReadLine());
            Console.Write("Input the sixth number: ");
            a6 = Int32.Parse(Console.ReadLine());

            //operations

            float average = ((float)a1 + (float)a2 + (float)a3 + (float)a4 + (float)a5 + (float)a6) / 6;

            //print average

            Console.WriteLine("The average of the numbers: " + average);
            Console.ReadLine();
        }
    }
}
