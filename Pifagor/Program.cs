using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pifagor
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c;
            int stepen = 2;
            




            for (a=1; a <= 1000;a++)
            {
                for (b = 1; b <= 1000; b++)
                {
                    for(c=1; c<=1000; c++)
                    {
                        if ((Math.Pow(a, stepen)) +(Math.Pow(b, stepen)) == Math.Pow(c, stepen))
                        {
                            Console.WriteLine("Ищем по степени");
                            if ((a < b) & (b < c) & (a < c))
                            {
                                Console.WriteLine("Ищем по равенству");
                                if (a + b + c == 1000)
                                {
                                    int composition = a * b * c;
                                    Console.WriteLine("Ура, нашли");
                                    Console.WriteLine("Число a:"+a);
                                    Console.WriteLine("Число b:"+b);
                                    Console.WriteLine("Число c:"+c);
                                    Console.WriteLine("Произведение равно:" + composition);
                                    Console.ReadKey();
                                }
                            }

                        }
                        
                    }
                }
                
               
            }
        }
    }
}
