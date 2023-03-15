using System;

namespace _11_Structs
{
  class Program
  {
    static void Main(string[] args)
    {
      //STRUCTS
      //Cria uma estrutura
      var produto = new Produto();
      //Vem com dados dos tipos padrão, para preencher os dados
      produto.Id = 1;
      produto.Titulo = "Mouse Gamer";
      produto.Preco = 197.23f;
      Console.WriteLine("Id: " + produto.Id);
      Console.WriteLine("Titulo: " + produto.Titulo);
      Console.WriteLine("Preço: " + produto.Preco);

      //Chamando o método construtor de Produto
      var produtoConstrutor = new Produto(1, "Playstation 1", 128.75f);
      Console.WriteLine("IdConstrutor: " + produtoConstrutor.Id);
      Console.WriteLine("TituloConstrutor: " + produtoConstrutor.Titulo);
      Console.WriteLine("PreçoConstrutor: " + produtoConstrutor.Preco);
      Console.WriteLine("PreçoEmDolarConstrutor: " + produtoConstrutor.PrecoEmDolar(5.70f));

    }
  }

  //Anatomia de uma estrutura normalmente é:
  struct Produto
  {
    //Propriedades
    public int Id;
    public string Titulo;
    public float Preco;

    //Métodos
    public float PrecoEmDolar(float dolar)
    {
      return Preco * dolar;
    }

    //Método Construtor, é um método com mesmo nome da STRUCT
    public Produto(int id, string titulo, float preco)
    {
      Id = id;
      Titulo = titulo;
      Preco = preco;
    }
  }
}

//DEFINIÇÕES
// ✔ Tipos de dado estruturado
// ✔ Apenas a estrutura, o esqueleto
// ✔ Tipo de valor
// ✔ Armazenam apenas outros tipos de dados
// ✔ Definido pela palavra STRUCT
// ✔ Composto de propriedades e métodos
// ✔ Nome sempre com maiúsculo
// O mesmo para a propriedades e métodos
// ✔ Criado a partir da palavra NEW
// Neste momento sim temos os valores

