using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCa.Test.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key = System.Console.ReadKey();
            System.Console.WriteLine(key.KeyChar);
            System.Console.WriteLine(key.Key);
        }
    }
}
