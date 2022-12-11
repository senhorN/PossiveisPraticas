using System;
using System.Collections.Generic;
using System.Text;

namespace possiveisPraticas
{
    class Calculadora
    {

        /* Operações matemáticas*/ 
        //Operação da soma 
        public void Somar( int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        //Operação de subtração
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x -y}");
        }
        //Operação de multiplicação 
        public void Multiplicacao(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        //Operador de divisão
        public void Divisao(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Potencia(int x, int y)
        {
            //Usei uma classe Math para a realização das potencias 
            double valor = Math.Pow(x, y);
            Console.WriteLine($"{x}^^{y} = {valor}");
        }


        #region função trigonometrica
        public void Seno(double angulo)//seno
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);

            Console.WriteLine($"seno de {angulo}º = {Math.Round(seno, 4)}");//Math.Round mostra quantas casas decimal eu quero
        }
        public void Coseno(double angulo)//coseno
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);

            Console.WriteLine($"coseno de {angulo}º  = {Math.Round(coseno, 4)}");
        }
        public void Tangente(double angulo)//tangente
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);

            Console.WriteLine($"tangente de {angulo}º = {Math.Round (tangente, 4)}");
        }
        public void RaizQuadrada(double x)
        {
            //sqaure root = raiz quadrada >> sqrt
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"A raiz quadrada  de {x} = {raiz}"); 
        }
        #endregion 
    }
}
