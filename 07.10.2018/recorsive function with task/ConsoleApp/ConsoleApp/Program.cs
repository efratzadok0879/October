using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static int PrintNumber(object res)
        {
            int number = (int)res;
            Thread.Sleep(1000);
            Console.WriteLine(res);
            return number * number;
        }
        static void PrintPows(int number)
        {
            Task<int> t = new Task<int>(PrintNumber, number);
            t.ContinueWith(prevTask =>
            {
                int result = prevTask.Result;
                if (result > 0)
                    PrintPows(result);
                else
                    Console.WriteLine("===============END PRINT POWS===============");
            });
            t.Start();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("===============START PRINT POWS===============");
            PrintPows(2);
            Console.Read();
        }
    }
}
