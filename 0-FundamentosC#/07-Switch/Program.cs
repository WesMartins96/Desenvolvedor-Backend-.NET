using System;

namespace _07_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //ESTRUTURA CONDICIONAL: SWITCH
            int valor = 1;
            switch (valor)
            {
                case 1: Console.WriteLine("1"); break;
                case 2: Console.WriteLine("2"); break;
                case 3: Console.WriteLine("3"); break;
                default: Console.WriteLine("Opção Errada"); break; //Se não for 1, 2 ou 3
            }
        }
    }
}

//DEFINIÇÕES 
// ✔ Utilizado quando temos muitas decisões
// ✔ Executado em cascata
// ✔ Devemos parar manualmente a execução com o comando BREAK
// ✔ Possui uma execução padrão chamada DEFAULT

