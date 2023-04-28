using System;

namespace _17_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //GUID
            var id = Guid.NewGuid();
            id.ToString();
            //id = new Guid("16b8c404-100c-4efe-ad48-5a0a0014bfb3"); valor fixo.
            Console.WriteLine(id); // um exemplo: 3707e3bb-218e-466f-9147-871743130840 ,sempre que executado ele gera numeros diferentes.
            //Pegar apenas 8 caracteres de uma string
            Console.WriteLine(id.ToString().Substring(0,8));

            //INTERPOLAÇÃO
            var price = 10.25;
            var promo = 9.99;
            var socio = 5.99;
            var text = "O preço do produto é: R$" + price;
            Console.WriteLine(text);

            var textOtimizado = $@"O preço do produto é R${price}, E APENAS HOJE SAI POR R${promo}!!!";
            Console.WriteLine(textOtimizado);

            var textFormat = string.Format("O PREÇO DO PRODUTO É R${0}, E APENAS HOJE ESTÁ POR R${1}, E PARA SOCIOS ESTÁ R${2}, APROVEITE!!!!", price, promo, socio);
            Console.WriteLine(textFormat); 
            //A função String.Format() em C# é usada para formatar strings (Data e Moedas também) e incluir valores de variáveis em posições específicas. 
            //É útil para criar strings personalizadas com diferentes formatos de variáveis. A função recebe como parâmetros uma string de formato e os objetos que serão inseridos na string.

            //COMPARAR
            var textoCompare = "Bom dia";
            Console.WriteLine(textoCompare.CompareTo("Boa tarde")); //Retorna um inteiro
            Console.WriteLine(textoCompare.Contains("Boa tarde")); //Retorna um bool
            Console.WriteLine(textoCompare.Contains("bom dia", StringComparison.OrdinalIgnoreCase)); //Ignorar o CaseSensitive

            //StartsWith e EndsWith
            var textoStartEnd = "Eu sou dev";
            Console.WriteLine(textoStartEnd.StartsWith("Eu")); //Verifica se começa com a string colocada como parâmetro e retorna um bool
            Console.WriteLine(textoStartEnd.StartsWith("eu", StringComparison.OrdinalIgnoreCase)); //Ignorando o CaseSensitive
            Console.WriteLine(textoStartEnd.StartsWith(" eu")); //Verifica se começa com a string colocada como parâmetro
            
            Console.WriteLine(textoStartEnd.EndsWith("dev")); //Verifica se termina com a string colocada como parâmetro
            Console.WriteLine(textoStartEnd.EndsWith("DEV", StringComparison.OrdinalIgnoreCase)); //ignora o CaseSensitive
            Console.WriteLine(textoStartEnd.EndsWith(" dev ")); //Verifica se termina com a string colocada como parâmetro


            //EQUALS
            var textoEquals = "Estudar é o melhor para ganhar dinheiro";
            Console.WriteLine(textoEquals.Equals("Estudar é o melhor para ganhar dinheiro")); //Verifica se o valor é identico e retorna um bool
            Console.WriteLine(textoEquals.Equals("ESTUDAR É O MELHOR PARA GANHAR DINHEIRO", StringComparison.OrdinalIgnoreCase)); //Ignora o CaseSensitive
            var numeroEquals = 33;
            Console.WriteLine(numeroEquals.Equals(18)); //Verifica se o valor é identico e retorna um bool
            Console.WriteLine(numeroEquals.Equals(33)); //Verifica se o valor é identico e retorna um bool
            



        }
    }
}

//GUID
// ✔ O GUID é um tipo de dado em C# utilizado para gerar identificadores únicos e exclusivos de 128 bits, 
//criados automaticamente pelo sistema através de um algoritmo complexo. 
//Ele é amplamente utilizado em sistemas distribuídos e aplicações que exigem segurança.
// ✔ GUID também aceita uma string como parâmetro exemplo: id = New Guid("16b8c404-100c-4efe-ad48-5a0a0014bfb3"); assim ficando com seu valor fixo.

//INTERPOLAÇÃO
// ✔ A interpolação de string em C# é uma forma simplificada de concatenar strings e valores numéricos ou de outras variáveis em uma única string. 
//É feita utilizando o símbolo "$" antes da string e inserindo as variáveis dentro de chaves "{}". 
//Exemplo: $"O valor de x é {x} e o valor de y é {y}". Isso é mais simples e legível do que concatenar várias strings e variáveis com o sinal "+".

//COMPARAR
// ✔ Realiza a comparação de strings usando o CompareTo(), e retorna um inteiro
// ✔ Realiza a comparação de strings usando o Contains(), e retorna um bool
// ✔ As comparações levam em conta o Case Sensitive para ignorar isso colocamos como segundo parametro o StringComparison.OrdinalIgnoreCase

//EQUALS
// ✔ Verifica se o valor é identico e retorna um bool
// ✔ As comparações do EQUALS devem ser feitas com os mesmos tipos de valor, se é uma string deve ser comparada a uma string, se é um int deve ser comparado com um int.