using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class Calculadora 
    {
        private int numero;
        public List<ICalcular> calculadoras;

        public Calculadora(int numero)
        {
            this.numero = numero;
            calculadoras = new List<ICalcular>();
            
        }

  

        public int GetNumero()
        {
            return numero;
        }
        public int Calcular(int operacion)
        {

            /*ICalcular numero2 = calculadoras[operacion];//elegir la operacion que quiero hacer
            int numero3 = GetNumero();//obtener el valor actual del numero
            numero =  numero2.Calcular(numero3);//aplicar la operacion al numero 
            return numero;//retornar el nuevo resultado*/

            if (operacion == 0)
            {
                PersonaQueSuma5 personaQueSuma5 = new PersonaQueSuma5();
                numero = personaQueSuma5.Calcular(numero);
            }
            else if (operacion == 1)
            {
                RobotFibonacci robotFibonacci = new RobotFibonacci();
                numero = robotFibonacci.Calcular(numero);
            }
            else if (operacion == 2)
            {
                PerroFactorial perroFactorial = new PerroFactorial();
                numero = perroFactorial.Calcular(numero);
            }
            else if(operacion == 3)
            {
                Cuadrado cuadrado = new Cuadrado();
                numero = cuadrado.Calcular(numero);
            }
            else if (operacion == 4)
            {
                Cubo cubo = new Cubo();
                numero = cubo.Calcular(numero);
            }
            else
            {
                return numero;
            }
            return numero;
        }
    }
}
