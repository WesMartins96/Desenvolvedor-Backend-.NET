using System;

namespace _03_TiposDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            //TIPOS PRIMITIVOS EM C-SHARP

            //BYTE e SBYTE
            // byte (8-bit)
                // 0 até 255
            // sbyte (8-bit)
                // -128 até 127
            //Note que o "sbyte" permite valores negativos, por isso no nome sbyte, o que significa "signed byte".   
            byte pequenoNumero = 5;
            sbyte negativoNum = -100;

            //NÚMEROS INTEIROS
            short n3 = -12; ushort n4 = 12;
            int n1 = -2; uint n2 = 2;
            long n6 = -300; ulong n5 = 5000;
            // short (16-bit)
                // -32.768 até 32.767
            //ushort (16-bit)
                // 0 até 65.535
            // int (32-bit)
                // -2.147.483.648 até 2.147.483.647
            // uint (32-bit)
                // 0 até 4.294.967.295
            // long (64-bit)
                // -9.223.372.036.854.775.808 até 9.223.372.036.854.807
            // uong (64-bit)
                // 0 até 18.446.744.073.709.551.615   

            //NÚMEROS REAIS
            float despesa = 2.500F; // Notação F
            double ganhos = 5.000;
            decimal lucros = 15.295M; // Notação M
            // float (32-bit)
                // -3.402823e38 até 3.402823e38
            // double (64.bit)
                // -1.79769313486232e308 até 1.79769313486232e308
            // decimal (128-bit)
                // (+ ou -)1.0 x 10e-28 até 7.9 x 10e28
            
            //BOOL
            bool isHuman = true;
            bool isAnimal = false;
            // bool (8-bit)
                // true ou false

            //CHAR    
            char sexo = 'M';
            // char (16-bit)
                // Qualquer caractere

            //STRING
            string meuNome =  "Wesley Martins";
            // string (?)
                // Uma cadeia de caracteres

            //VAR
            var idade = 26; //Será do tipo int
            var nome = "Gael"; //Será do tipo string
            var dinheiro = 2.99; //Será do tipo double

            //OBJECT
            object age = 26; //Será do tipo object
            object name = "Beatriz Cristina"; //Será do tipo object

            //NULL
            int? quantidade = null; 
            //Podemos atribuir "null" a um objeto
            //Desde que o mesmo seja marcado como nullable
                //Usando interrogação(?) na frente do tipo
            //Se uma chamada a um valor nulo for feita um erro será apresentado
               
            
        }
    }
}

//DEFINIÇÕES
// ✔ Também conhecidos como BUILD-IN TYPES
// ✔ São tipos base cujo outros tipos (complexos) irão derivar
// ✔ Definir o tipo correto otimixa a execução do programa
// ✔ Armazenam o valor e não a referência para um item na memória
//SÃO CLASSIFICADOS EM:
    // ✔ Tipos Simples (Simple Types)
    // ✔ Enumeradores (Enums)
    // ✔ Estruturas (Structs)
    // ✔ Tipos Nulos (Nullable Types)

//DEFINIÇÕES II - BYTE
// ✔ O tipo BYTE é utilizado para representar um byte de fato.
// ✔ Em diversos casos precisamos da cadeia de bytes de um arquivo por exemplo.
    //Também chamamos de 'byte array'.
// ✔ Temos também "sbyte", que permite valores negativos
//SIGNED e UNSIGNED
// ✔ Valores com sinal como "-" por exemplo, sao chamados de "signed"

//DEFINIÇÕES III - NÚMEROS INTEIROS
// ✔ Números inteiros, ou seja, sem pontuação, podem ser definidos pelos tipos.
    // short / ushort
    // int / uint
    // long / ulong
// ✔ Assim como temos o "signed" nos bytes, nos números por padrão são permitidos valores negativos.
// ✔ Então usamos o UNSIGNED para definir que o mesmo não pode receber valores negativos.
// ✔ O tipo INT é o mais comum de ser encontrado.

//DEFINIÇÕES IV - NÚMEROS REAIS
// ✔ Números reais exigem uma maior precisão, ou seja, com pontuação.
    // float (Notação F)
    // double
    // decimal (Notação M)
// ✔ Possuem assimilação negativa por padrão, dispensando uso do SIGNED/UNSIGNED em seus tipos.    

//DEFINIÇÕES V - BOOL
// ✔ Tipo booleano, armazena apenas TRUE e FALSE (verdadeiro ou falso)
// ✔ Definido pela palavra reservada "bool"

//DEFINIÇÕES VI - CHAR
// ✔ Utilizado para armazenar apenas um caractere no formato Unicode
// ✔ Definido pela palavra reservada "char"
// ✔ A atribuição de um valor char é dada por aspas simples '';

//DEFINIÇÕES VII - STRING
// ✔ Armazena uma cadeia de caracteres
// ✔ Podemos pensar nele como uma lista de 'char'
// ✔ Definido pela palavra reservada "string"
// ✔ A atribuição de um valor string é dada por aspas duplas

//DEFINIÇÕES VIII - VAR
// ✔ Substitui o nome de um TIPO
// ✔ Será o tipo do primeiro valor atribuido
// ✔ Recomendado o uso
    // Deixe para usar VAR quando já dominar os tipos.

//DEFINIÇÕES IX - OBJECT    
// ✔ Tipo genérico que recebe qualquer valor ou objeto
// ✔ Caso não saiba o tipo da informação ou ela seja de vários tipos diferentes
// ✔ Não possui intelisense(Ajuda dos editores) por ser um tipo desconhecido.
// ✔ Evite usar.

//DEFINIÇÕES X - NULL
// ✔ Significa vazio, nada.
// ✔ Diferente de zero ou uma string vazia.
// ✔ Todo tipo, primitivo ou complexo pode receber o valor null.
// ✔ O tipo deve ser marcado como "Nullable Type"