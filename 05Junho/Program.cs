using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Junho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age1;
            Console.WriteLine("Digite a sua idade?");
            age1 = int.Parse(Console.ReadLine());

            if (age1 >= 18 )
            {
                Console.WriteLine("Me da dinheiro que eu te deixo dirigir\n\n");

            }
            else
            {
                Console.WriteLine("Espere mais alguns anos\n\n");
            }
            Main(null);
        }
    }
}
