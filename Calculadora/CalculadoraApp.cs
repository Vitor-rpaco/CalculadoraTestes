using System;
using System.Xml.Schema;

namespace Calculadora
{
    public class CalculadoraApp
    {
        static void Main(string[] args)
        {
            
        }

        public double Soma(double a, double b)
        {
            return ( a + b );
        }

        public double Multiplicar(double a, double b)
        {
            return ( a * b);
        }

        public double Subtrair(double a, double b)
        {
            return ( a - b );
        }

        public double Divisao(double a, double b)
        {
            try { 
                return (a / b);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro de divisão: {ex}");
                throw new System.ArithmeticException();
            }

            return 0;
        }
    }
}
