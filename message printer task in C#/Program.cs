using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace message_printer_task_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the message: C# is fun i am going to code C# tomorrow");
            var message = Console.ReadLine();
            Console.WriteLine("\n");

            char[] messageArray = message.ToCharArray();

            Console.Write(messageArray);

            Console.WriteLine("\n");

            Array.Reverse(messageArray);
            Console.Write(messageArray);
            Console.WriteLine("\n");
            
            foreach (char c in message) Console.WriteLine(c);

            Console.WriteLine("\n");

            foreach (char c in messageArray) Console.WriteLine(c);

            Console.ReadLine();


            


        }
    }
}
