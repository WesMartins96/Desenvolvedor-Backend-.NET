using System;

namespace _14_ProjetoCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Projeto de uma Calculadora de dois valores para fixar os conteúdos estudados:
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O Que Deseja Fazer?");
            Console.WriteLine("[1] - Soma");
            Console.WriteLine("[2] - Subtração");
            Console.WriteLine("[3] - Divisão");
            Console.WriteLine("[4] - Multiplicação");
            Console.WriteLine("[5] - Sair");
            
            Console.WriteLine("-------------");
            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());
            
            switch(res)
            {
                case 1 : Soma(); break;
                case 2 : Subtracao(); break;
                case 3 : Divisao(); break;
                case 4 : Multiplicacao(); break;
                        //Para fechar a aplicação console
                case 5 : System.Environment.Exit(0); break;
                default : Menu(); break;
            }
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("SOMA");
            Console.WriteLine("Primeiro Valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            float resultado = valor1 + valor2;
            Console.WriteLine("Resultado da soma dos números é: " + resultado);
            Console.WriteLine($"Resultado da soma, usando INTERPOLAÇÃO '$': {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("SUBTRAÇÃO");
            Console.WriteLine("Primeiro Valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            float resultado = valor1 - valor2;
            Console.WriteLine("Resultado da subtração dos números é: " + resultado);
            Console.WriteLine($"Resultado da subtração, usando INTERPOLAÇÃO '$': {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("DIVISÃO");
            Console.WriteLine("Primeiro Valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            float resultado = valor1 / valor2;
            Console.WriteLine("Resultado da divisão dos números é: " + resultado);
            Console.WriteLine($"Resultado da divisão, usando INTERPOLAÇÃO '$': {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("MULTIPLICAÇÃO");
            Console.WriteLine("Primeiro Valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            float resultado = valor1 * valor2;
            Console.WriteLine("Resultado da multiplicação dos números é: " + resultado);
            Console.WriteLine($"Resultado da multiplicação, usando INTERPOLAÇÃO '$': {resultado}");
            Console.ReadKey();
            Menu();
        }
    }
}
