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

            int[] numeros = new int[10];

            numeros = CapNumeros();
            Console.Clear();
            ImparPar(numeros);
            Console.Read();
        }
        public static int[] CapNumeros()
        {
            int[] numeros = new int[10];
            int n1;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite o numero " + (i + 1) + ": ");
                n1 = Convert.ToInt32(Console.ReadLine());

                numeros[i] = n1;
            }
            return numeros;
        }
        public static void ImparPar(int[] numeros)
        {
            int par = 0, impar = 0;
            for (int i = 0; i < 10; i++)
            {
                if (numeros[i] % 2 == 0)
                    par++;
                else
                    impar++;
            }

            Console.WriteLine(par + " numeros par");
            Console.Write(impar + " numeros impar");
        }
    }
}
