using System;
using System.Threading;

namespace _15_ProjetoCronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação de um cronômetro para fixar o conhecimento estudado
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("[S] - Contar em Segundos => 10s = 10 Segundos");
            Console.WriteLine("[M] - Contar em Minutos => 1m = 1 Minuto");
            Console.WriteLine("[Ctrl + C] - Sair");
            Console.WriteLine("Quanto tempo deseja Contar?");

            string data = Console.ReadLine().ToLower();

                            //Pegar o ultimo caractere de uma string usando Substring e Length
            char type = char.Parse(data.Substring(data.Length - 1, 1));
                            //Pegar todos os caracteres menos o ultimo de uma string usando Substring e Length
            int time = int.Parse(data.Substring(0, data.Length - 1));

            //Definindo o tempo (om base em segundos)
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Preparar...");
            Thread.Sleep(1000);
            Console.WriteLine("Apontar..");
            Thread.Sleep(1000);
            Console.WriteLine("CONTAR...");
            Thread.Sleep(1500);

            StartCronometro(time);
        }

        static void StartCronometro(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);

                //fazer a aplicação esperar um tempo para fazer a ação
                Thread.Sleep(1000); 
            }

            Console.Clear();
            Console.WriteLine("Cronômetro Finalizado.");

            //fazer a aplicação esperar um tempo para fazer a ação
            Thread.Sleep(1500);

            //Voltar ao menu após a contagem
            Menu();
        }
    }
}
