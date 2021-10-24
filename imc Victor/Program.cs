using System;

namespace imc_Victor
{
    class Program
    {
        static void Main(string[] args)
        {
            double total, altura, peso;
            Console.WriteLine("Calcular Imc");
            Console.WriteLine("Quantidade de pessoas que serão calculadas?: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i}ª Pessoa: ");
                Console.WriteLine();
                Console.WriteLine("Insira o peso:");
                peso = double.Parse(Console.ReadLine());
                Console.Write("Insira a altura: ");
                altura = double.Parse(Console.ReadLine());
                total = peso / (altura * altura);
                Console.WriteLine("Total: " + total.ToString("F2"));
                if (total < 18.5)
                    Console.WriteLine("Magreza");
                if (total >= 18.5 && total < 24.9)
                    Console.WriteLine("Normal");
                if (total > 24.9 && total < 30)
                    Console.WriteLine("SobrePeso");
                if (total >= 30)
                    Console.WriteLine("Obesidade");

            }
        }
    }
}
