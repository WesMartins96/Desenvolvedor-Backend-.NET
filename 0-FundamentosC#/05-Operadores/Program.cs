using System;

namespace _05_Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            //OPERADORES ARITMÉTICOS
            //Em caso de uso de números inteiros
                //Se o valor dor real, será arredondado
                // 4.4 => 5
            int soma = 25 + 22; //47
            int subtracao = 25 - 22; //3
            int multiplicacao = 25 * 22; //550
            int divisao = 22 / 5; // 4 (Foi arredondado)

            //Utilizamos parênteses para redefinir a ordem de execução
            int x = 2 + 2 * 2; //6
            int y = 2 + (2 * 2); //6 (Mesmo que o anterior)
            int z = (2 + 2) * 2; //8 (Executou a soma primeiro)


            //OPERADORES DE ATRIBUIÇÃO
            int n = 0; //Atribuição
            n += 5; // n = n + 5;
            n -= 1; // n = n - 1;
            n *= 10; // n = n * 10;
            n /= 2; // n = n / 2;

            //OPERADORES DE COMPARAÇÃO
            // == Igual 
            // != Diferente 
            // >  Maior que 
            // <  Menor que 
            // >= Maior ou igual a 
            // <= Menor ou igual que 
            int w = 25;
            //w == 0; //FALSE
            //w != 0; //TRUE
            //w > 0; //TRUE
            //w < 0; //FALSE
            //w <= 0; //FALSE
            //w >= 0; //TRUE

            //OPERADORES LÓGICOS
            // AND
                //Deve atender TODAS as condições
                // &&
            // OR
                //Deve atender uma condição já retorna verdadeiro
                // ||
            // NOT
                // ! 
            int l = 12;
            bool entre = (l > 25) && (l < 40); //FALSE
            bool ou = (l > 25) || (l < 40); //TRUE
            bool negacao = !(l < 25); //FALSE
        }
    }
}

//DEFINIÇÕES
// ✔ Soma => +
// ✔ Subtração => -
// ✔ Multiplicação => *
// ✔ Divisão => /
    // Multiplicação e Divisão são executada primeiro
    // Caso queira executar em outra ordem, usar parênteses ()
    // Aceita short, int, float, double e decimal

//DEFINIÇÕES II - OPERADORES DE ATRIBUIÇÃO
// ✔ Utilizamos igual '=' para atribuir um valor
// ✔ Porém, podemos utilizar igual junto a outro operador aritmético
    // (x += 5) é o mesmo que (x = x + 5)

//DEFINIÇÕES III - OPERADORES DE COMPARAÇÃO
// ✔ Podemos comparar qualquer tipo de dado
    // Números, strings e bytes
// ✔ A comparação SEMPRE retorna verdadeiro ou falso
    // TRUE ou FALSE

//DEFINIÇÕES IV - OPERDADORES LÓGICOS
// ✔ Usado para operações condicionais
// ✔ Retorna SEMPRE verdadeiro ou falso
