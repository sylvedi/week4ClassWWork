using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4ClassWWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Evalute the following logical expressions.
            int val = 35;
            bool value;
            int n = -5;

            Console.WriteLine(value = val + 3 ==38);
            Console.WriteLine(value = val * 3 > 120);
            Console.WriteLine(value = val - 30 < -5 + 10);
            Console.WriteLine(value = n < 0);
            Console.WriteLine(value = val/n + 8 <= 0);
            Console.WriteLine(value = val % 2 != 0);
            Console.WriteLine("-----------");
            //Correspond to each phrase 

            int m = 4;
            int a = 6;
            int b = 3;
            int c = 9;
            char ch = '4';

            Console.WriteLine(value = m > 10);
            Console.WriteLine(value = a %2 == 0 && b %2 == 0 && c %2==0);
            Console.WriteLine(value = a%2==0 || b%2==0 || c%2==0);
            Console.WriteLine(value = ('2' <= ch) && (ch <= '5'));
            Console.WriteLine();


            
            Console.WriteLine((m%2!=1) && (n%2!=1));
            Console.WriteLine((m>n)&&(m<=n+5));
            Console.WriteLine((m%2==0)&&(n%2==0));
            Console.WriteLine(((m%2==0)||(n%2==0))&& !((m%2==0)||(n%2==0)));
            Console.WriteLine();

            bool p = true;
            bool q = false;
            bool r = false;

            Console.WriteLine(!r);
            Console.WriteLine(r &&p);
            Console.WriteLine(!(r || q) && p);
            Console.WriteLine((r && !r) || (p && p));
            Console.WriteLine((p && !q) || (!p && q));
            Console.WriteLine((r || !r) && (p || !p));










        }
    }
}
