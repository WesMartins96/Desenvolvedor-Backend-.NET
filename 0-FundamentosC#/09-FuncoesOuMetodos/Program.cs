using System;

namespace _09_FuncoesOuMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            //FUNÇÕES OU MÉTODOS
            // Invocação do método
            MeuMetodo(".NET é massa!!!");
            MeuMetodo("Quero ser expecialista em .NET");

            // Armazena o resultado em uma varíavel
            var nome = RetornaNome("Wesley", "Martins");
            // Imprime o nome na tela
            Console.WriteLine(nome);
        }

        //DEFINIÇÕES DO MÉTODO
        static void MeuMetodo(string parametro)
        {
            Console.WriteLine(parametro);
        }

        //DEFINIÇÃO DO MÉTODO
        // Retorna uma string e recebe vários parâmetros
        static string RetornaNome(string nome, string sobrenome){
            // Retorna o nome e sobrenome
            return "Nome Completo: " + nome + " " + sobrenome;
        }
    }
}

//DEFINIÇÕES 
// ✔ Podemos segmentar nosso programa em funções.
// ✔ Também conhecidos como métodos.
// ✔ MAIN é um exemplo de método.
// ✔ Possui um retorno, um nome e parâmetros.
// ✔ Esta composição é chamada de assinatura.
// ✔ Começam sempre com letra maiúscula.

