using System;

namespace _10_TiposReferenciaEValor
{
    class Program
    {
        static void Main(string[] args)
        {
            //TIPOS DE REFERÊNCIA 
            int x = 25;
            int y = x; // "y" é uma cópia de "x"
            Console.WriteLine("x: " + x); // 25
            Console.WriteLine("y: " + y); // 25
            x = 32; //Somente "x" foi alterado
            Console.WriteLine("x alterado: " + x); // 32
            Console.WriteLine("y: " + y); // 25


            //TIPOS DE VALOR
            var arr = new string[2];
            arr[0] = "Item 1";

            var arr2 = arr;
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);

            arr[0] = "Item 2 - alterado";
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);
            //Alterou os dois itens pois neste caso não temos uma cópia e sim uma referência.
        }
    }
}

//DEFINIÇÕES
// ✔ A memória é dividida em duas partes, HEAP e STACK.
// ✔ HEAP armazena os dados.
// ✔ STACK armazena as referências para os dados.

//DEFINIÇÕES II - STACK
// ✔ Quando armazenamos um valor, a memória é alocada.
// ✔ Este espaço armazena o dado criado.
// ✔ Nossa variável acessa este dado diretamente.
// ✔ Se assimilarmos uma variável do tipo de valor a outra.
    // O valor será COPIADO.
    // Ambas serão independentes.
// ✔ Built-in, Structs, Enums.
// ✔ Garbage Collector não acessa o STACK.

//DEFINIÇÕES III - HEAP
// ✔ Armazenam o endereço do objeto que contém os dados.
// ✔ Não armazena os dados em si.
// ✔ São armazenados em um local da memória chamado de HEAP.
// ✔ Ao assimilar uma variável.
    // Criará uma REFERÊNCIA.
    // Aponta para a mesma informação.
    // Não são independentes.
// ✔ Quando não mais utilizados são marcados para exclusão.
// ✔ Garbage Collector passa removendo todos eles.
// ✔ Classes, Objects, Arrays...


