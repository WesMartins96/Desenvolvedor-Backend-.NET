using System;

namespace _08_LacosDeRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            //LAÇOS DE REPETIÇÃO: FOR
            for (var i = 0; i <= 5; i++)
            {
                Console.WriteLine("Usando For: " + i);
            }


            //LAÇOS DE REPETIÇÃO: WHILE
            var valor = 0;
            //Conta de 0 a 5
            //Exibe de 0 a 5 na tela
            while (valor <= 5)
            {   
                Console.WriteLine("Usando While: " + valor);
                valor++;
            }


            //LAÇOS DE REPETIÇÃO: DO/WHILE
            var value = 0;
            do
            {
                Console.WriteLine("Usando Do/While: " + value);
                value++;
            } while (value <= 5);

        }
    }
}

//DEFINIÇÕES - FOR
// ✔ Tradução "Para", ou seja, para cada item em um valor...
// ✔ Executa uma determinada ação várias vezes.
// ✔ Definido pela palavra FOR.
// ✔ Exige 3 parâmetros:
    // Contador
    // Condição
    // Incremento
// for(var i = 0; i <= 5; i++)

//DEFINIÇÕES II - WHILE
// ✔ Tradução "Enquanto", ou seja, enquanto uma condição for verdadeira...
// ✔ Definido pela palavra WHILE
// ✔ Exige apenas uma condição
// ✔ Checa a condição ANTES de executar

// DEFINIÇÕES III - DO/WHILE
// ✔ Tradução "Faça", ou seja, realiza uma ação enquanto...
// ✔ Definido pela palavra DO/WHILE
// ✔ Exige apenas uma condição no WHILE
// ✔ Checa a condição DEPOIS de executar
