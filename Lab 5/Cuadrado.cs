using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class Cuadrado : ICalcular
    {
        public int Calcular(int numero1)
        {
            numero1 = Convert.ToInt32(Math.Pow(numero1, 2));//no soporta numeros muy grandes
            return numero1;
        }
    }
}
