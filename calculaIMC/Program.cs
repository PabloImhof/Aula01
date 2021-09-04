using System;

namespace calculaIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("   Calculando IMC    ");
            Console.WriteLine("----------------------");

            calculaIMC();
           // resultadoIMC();
        }

        static void calculaIMC()
        {
            Console.WriteLine("Informe seu peso");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe seu altura");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = (peso / (altura * altura));
            Console.WriteLine(@$"Seu IMC é {Math.Round(imc, 2)}");

            string tabelaimc = resultadoIMC(imc);
            Console.WriteLine(tabelaimc);
            
        }

        static string resultadoIMC(double valorIMC)
        {
            if (valorIMC < 18.5)
            {
                return "Magreza";
            }
            else if (valorIMC == 18.5 && valorIMC < 24.9)
            {
                return "Normal";
            }
            else if (valorIMC == 24.9 && valorIMC < 30)
            {
                return "Sobrepeso";
            }
            else
            {
                return "Sobrepeso";
            }

        }

    }
}
