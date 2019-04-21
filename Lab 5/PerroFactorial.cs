using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class PerroFactorial : ICalcular
    {
        public int Calcular(int numero1)
        {
            if (numero1 > 10)//poner maximo al numero
            {
                numero1 = 10;
            }
            int resultado = 1;

            for (int i = 1; i <= numero1; i++)
            {
                resultado = resultado * i;
            }
            numero1 = resultado;//se supone que quiero el factorial, si hago que retorne resultado, el numero no cambia
            return numero1;
        }
    }
}
