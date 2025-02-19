// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace NXUAT
{
    class program
    {
        static void Main(string[] args)
        {
            string s;
            int a, b, c;
            s = Console.ReadLine();
            //Console.WriteLine("so n la: " + s);
            a =int.Parse(s);
            s = Console.ReadLine();
            b = int.Parse(s);
            c = a + b;
           Console.WriteLine(c);
        }
        
    }
}

