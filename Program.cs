using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            string astr, bstr, cstr;

            a = 30; //assigning value
            b = 45;

            Console.WriteLine("Enter value of a ");
            astr = Console.ReadLine();
            Console.WriteLine("Enter value of b ");
            bstr = Console.ReadLine();

            //cstr = astr + bstr;

            a = int.Parse(astr);
            b = Convert.ToInt32(bstr);

            c = a + b; //operation

            Console.WriteLine("{0}+{1}={2}", a,b,c);
            Console.ReadKey();

        }
    }
}
