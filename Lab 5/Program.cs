using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int valorInicial = random.Next(1, 10);
            

            Calculadora lista = new Calculadora(valorInicial);
            lista.calculadoras.Add(new PersonaQueSuma5());
            lista.calculadoras.Add(new RobotFibonacci());
            lista.calculadoras.Add(new PerroFactorial());
            lista.calculadoras.Add(new Cuadrado());
            lista.calculadoras.Add(new Cubo());
            
            Console.WriteLine("El numero es: "+ valorInicial);
            Console.WriteLine(" ");
            Console.WriteLine("¿Cuantas operaciones desea realizar?");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            int resultado = valorInicial;
            int operacion = 1;

            while (cantidad > 0)
            {
                Console.WriteLine("Seleccione que operación desea realizar");
                Console.WriteLine("[0] Sumar 5");
                Console.WriteLine("[1] Fibonacci");
                Console.WriteLine("[2] Factorial");
                Console.WriteLine("[3] Elevar al cuadrado");
                Console.WriteLine("[4] Elevar al cubo");
                operacion = Convert.ToInt32(Console.ReadLine());

                Calculadora calculadora = new Calculadora(resultado);
                resultado = calculadora.Calcular(operacion);

                Console.WriteLine("Resultado de la operación: "+ resultado);
                Console.WriteLine(" ");


                cantidad -= 1;
                if (cantidad == 0)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Se acabaron las operaciones");
                }
            }
            Console.ReadLine();
        }
    }
}
