using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Експоненциален_запис
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            decimal s = 0;
            for (int i = 0; i < a; i++)
            {
                var b = decimal.Parse(Console.ReadLine());
                s =s+ b;
            }
            Console.WriteLine(s);
        }
    }
}
