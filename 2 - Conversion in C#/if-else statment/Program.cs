using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace if_else_statment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //user inp
            Console.Write("Enter the first number: ");
            string numberAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAInput);
            //user inp
            Console.Write("enter the second number: ");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBInput);

            int answer = numberA * numberB;

            // Console.Write("value of " + numberA + " * " + numberB + ": " + answer);
            Console.Write("value of " + numberA + " * " + numberB + ": ");

            string answerInput = Console.ReadLine();
            int actualAnswer = Convert.ToInt32(answerInput);

            if (actualAnswer == answer)
            {
                Console.WriteLine("corret answer");
            }
            else if (answer != actualAnswer)
            {
                Console.WriteLine("close but it was wrong");
            }
            Console.ReadLine();
        }
    }
}
