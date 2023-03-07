using System;

namespace _04_Conversao
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONVERSÃO IMPLÍCITA
            float valor = 25.8F;
            int outro = 25;
            valor = outro; //Conversão Implícita

            //CONVERSÃO EXPLÍCITA
            int value = 100;
            uint valueSemSinal = (uint)value; //Conversão Explícita 
            Console.WriteLine(valueSemSinal);

            //PARSE
            int inteiro = int.Parse("100"); //Transformando uma string em um int
            Console.WriteLine(inteiro);

            //CONVERT
            int numero = Convert.ToInt32("120"); //Transformando uma string em um Int32
            Console.WriteLine(numero);

            
        }
    }
}

//DEFINIÇÕES - CONVERSÃO IMPLÍCITA
// ✔ É comum precisarmos transformar um dado tipo X para tipo Y.
// ✔ Existem dois tipos de conversão, as implícitas e as explícitas.
// ✔ As implícitas são conversões que
    // Podem ser executadas apenas com passagem de dados
    // Possuem tipos compatíveis.

//DEFINIÇÕES II - CONVERSÃO IMPLÍCITA
// ✔ A conversão anterior ocorrei pois um npumero real pode receber um npumero inteiro.
// ✔ Porém, ao contrário não aconteceria.
    // Um npumero inteiro não tem pontuação
    // Logo ele não poderia receber um npumero real.
// ✔ A conversão só ocorrerá se
    // O tipo de dado for compatível.
    // O tamanho do dado for compatível.    
// ✔ Em caso de números a precisão pode ser alterada.
// ✔ Qualquer situação adversa causará erro.

//DEFINIÇÕES III - CONVERSÃO EXPLÍCITA
// ✔ Ocorre quando os tipos não são compátiveis
// ✔ É dada pelo uso do tipo entre parênteses antes da atribuição
// ✔ Segue as mesmas regras anteriores

//DEFINIÇÕES IV - PARSE
// ✔ Método presente em todo tipo primitivo
// ✔ Usado para converter um caractere ou string para um tipo qualquer
// ✔ Caso haja alguma incompatibilidade, gera um erro

//DEFINIÇÕES V - CONVERT
// ✔ Similar ao PARSE
// ✔ Porém permite converter vários tipos de valor
    // Não apenas string
// ✔ Devemos informar o tipo na chamada da conversão