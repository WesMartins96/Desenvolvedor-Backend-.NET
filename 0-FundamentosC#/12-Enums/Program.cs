using System;

namespace _12_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            //ENUMERADORES

            //Sem Enumerador
            //var cliente = new Cliente("Wesley Martins", 1);

            //Com Enumerador
            var cliente = new Cliente("Wesley", EEstadoCivil.Casado);
            Console.WriteLine(cliente.Nome);
            Console.WriteLine(cliente.EstadoCivil);
            Console.WriteLine((int)cliente.EstadoCivil);
        }
    }

    //Anatomia de um Enumerador (Enum)
    enum EEstadoCivil
    {
        Solteiro = 1,
        Casado = 2,
        Divorciado = 3
    }

    struct Cliente
    {
        public Cliente(string nome, EEstadoCivil estadoCivil)
        {
            Nome = nome;
            EstadoCivil = estadoCivil;
        }
        public string Nome;
        public EEstadoCivil EstadoCivil;
    }
}

//DEFINIÇÕES 
// ✔ Usado para fornecer uma melhor visualização do código
// ✔ Substituem o uso de inteiros
// ✔ Usado em listas curtas
// ✔ Usado em dados fixos
// Hard Coded
// ✔ Sempre maiúsculo
// Começa com a letra E

