using System;

namespace _14_ProjetoCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Projeto de uma Calculadora para fixar os conteúdos estudados:
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            float resultado = valor1 + valor2;
            Console.WriteLine("Resultado da soma dos números é: " + resultado);
            Console.WriteLine($"Resultado da soma, usando INTERPOLAÇÃO '$': {resultado}");
        }
    }
}
