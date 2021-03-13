using System;

namespace AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
            string entradaBase;
            string entradaAltura;
            
            decimal tbase;
            decimal altura;
            decimal soma;
            decimal divisao;
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Digite a base e a altura do triângulo retângulo:");
            Console.WriteLine("------------------");
            Console.Write("Base..:");
            entradaBase = Console.ReadLine();
            Console.Write("Altura:");
            entradaAltura = Console.ReadLine();
            Console.ResetColor();

            tbase = Convert.ToDecimal(entradaBase);
            altura = Convert.ToDecimal(entradaAltura);
            soma = tbase * altura;
            divisao = soma / 2;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\nArea..: {divisao:N1}");
            Console.ResetColor();

            


        }
    }
}
