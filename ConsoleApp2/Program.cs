using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //int x = 8;
                //Console.WriteLine(++x);
                //Console.WriteLine(x);

                int n;
                do
                {
                    n = int.Parse(Console.ReadLine());
                }
                while (n<0);

                int i = 1;//счетчик цикла
                int S = 0;

                while (i <= n)
                {
                    S += i;
                    i++;
                }
                Console.WriteLine(S);

                S = 0;
                for(int j=1;j<=n;j++)
                {
                    S += j;
                }
                Console.WriteLine(S);

                S = 0;
                i = 1;
                do
                {
                    S += i;
                    i++;
                }
                while (i<=n);
                Console.WriteLine(S);
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
