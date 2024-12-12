using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int num1, num2, num3, num4, num5, num6;
      
            num1 = 0;
            num2 = 5;
            num3 = 10;
            num4 = 15;
            num5 = 20;
            num6 = 25;

            num3 *= num5;
            num4 -= num6;
            num1 += num2;

           Console.WriteLine(--num1 + num2++);
           Console.WriteLine(num3-- + ++num4);
           Console.WriteLine(num5-- + num6++);
        }
        
    }
}
