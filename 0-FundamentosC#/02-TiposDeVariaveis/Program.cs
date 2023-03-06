using System;

namespace _02_TiposDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIÁVEIS EM C-SHARP
            int idade; // Correto inicia com ZERO
            int numero = 26; // Correto inicia com 26
            var age = 3; // Correto inicia com 3
            //var teste; // Errado, o TIPO var precisa ser definido

            //CONSTANTES EM C-SHARP
            //const int IDADE_MINIMA; //Errado campo const espera um valor ao ser iniciado.
            const int IDADE = 26; // Correto inicia com 26
            //const var IDADE_MAXIMA = 101; // Errado, variáveis do TIPO 'var' não podem ser constantes.

            
        }
    }
}

//DEFINIÇÕES
// ✔ Uma variável é algo que utilizamos para armazenar uma informação.
// ✔ Ser variável significa que seu valor pode ser alterado a qualquer momento, ou seja, ele pode variar.
// ✔ Sempre que 'criamos' uma variável, dixmeos que estamos inicializando ela.

//DEFINIÇÕES II
// ✔ Podemos usar um TIPO ou a palavra reservada 'var' para criar uma variável.
// ✔ No C-Sharp o tipo vem sempre antes do nome da variável.
// ✔ Podemos informar um valor já na criação da variável.
// ✔ Se não informado o valor padrão será aplicado.

//DEFINIÇÕES III - CONSTANTES
// ✔ Também utilizamos uma constante para armazenar uma informação
// ✔ As constantes NÃO PODEM ser alteradas
// ✔ Uma vez criadas somos obrigados a atribuir um valor.
// ✔ Feito isso elas não poderão ser modificadas novamente.
// ✔ Não funcionam com a utilização de 'var'.
// ✔ São mais orimizadas que as variáveis
// ✔ Recomendadas para usos frequentes