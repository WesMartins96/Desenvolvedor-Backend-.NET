using System;
using System.IO;

namespace _16_EditorTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação de um Editor de Texto para fixar o conteudo estudado
            Menu();

        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("[1] - Abrir Arquivo");
            Console.WriteLine("[2] - Criar Novo Arquivo");
            Console.WriteLine("[0] - Sair");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0 : System.Environment.Exit(0); break; 
                case 1 : Abrir(); break; 
                case 2 : Editar(); break; 
                default : Menu(); break;
            }
        }

        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do Arquivo?");
            string path = Console.ReadLine();

            //sempre que for ler ou salvar um arquivo temos que usar o "using"
            using(var file = new StreamReader(path))
            {                       
                                    //ler o texto até o final
                string texto = file.ReadToEnd();
                Console.WriteLine(texto);
            }
            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu Texto Abaixo");
            Console.WriteLine("ESC para Sair");
            Console.WriteLine("-----------------------");

            string texto = "";
            
            //Pegar a tecla ESC para sair
            //Pegar tudo que foi digitado e guardar na variavel texto
            do
            {
                texto += Console.ReadLine();
                //salvar com quebra de linha
                texto += Environment.NewLine;
                        
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(texto);
        }

        static void Salvar(string texto)
        {
            Console.Clear();
            Console.WriteLine("\\Qual o caminho para salvar o arquivo?");
            Console.WriteLine("Não se esqueça do nome do arquivo no final do path. exemplo: \\texto.txt ");
            Console.Write("Digite aqui: ");
            var path = Console.ReadLine();

            //"using" Abri e fecha automaticamente o objeto, melhor modo para escrever arquivos em .NET
            using(var file = new StreamWriter(path))
            {
                file.Write(texto);
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Console.ReadLine();
            Menu();
        }
    }
}
