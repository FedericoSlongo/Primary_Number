using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeri_Primi
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            bool Try_pep=false;
            do
            {
                
                if (Try_pep)
                {
                    Console.WriteLine("Il numero inserito non è correto");
                }

                Console.WriteLine("Inserire il numero");
            } while (Try_pep = !int.TryParse(Console.ReadLine(), out num));

            for (int i = 2; i <= num; i++)
            {
                if (i == num)
                {
                    Console.WriteLine($"{i} è un numero primario");
                }
                else if (num % i == 0)
                {
                    Console.WriteLine( $"{num} non è un numero primario, puo essere diviso da {i}");

                }
                Console.ReadKey();
            }
        }
    }
}
