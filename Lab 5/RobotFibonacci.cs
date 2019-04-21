using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class RobotFibonacci : ICalcular
    {
        public int Calcular(int numero1) 
        {

            if (numero1 > 10)
            {
                numero1 = 10;
            }
            int a, b, i, auxiliar;
            a = 0;
            b = 1;
            for (i = 0; i < numero1; i++)
            {
                auxiliar = a;
                a = b;
                b = auxiliar + a;
                Console.WriteLine(a);
                continue;
            }
            return numero1;
        }
        
    }
}
