using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deznumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int par = 0;
            int impar = 0;

            int[] numeros = new int[10];
            

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite o numero " + (i+1) + ": ");
                n1 = Convert.ToInt32(Console.ReadLine());

                numeros[i] = n1;

            }
            Console.Clear();

            for (int i = 0; i < 10; i++)
            {
                if (numeros[i] % 2 == 0)
                    par++;
                else
                    impar++;
            }

            Console.WriteLine(par + " numeros par");
            Console.Write(impar + " numeros impar");

            Console.Read();

            



        }
    }
}
