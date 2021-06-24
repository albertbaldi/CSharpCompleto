using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secao04_Exercicio01
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
      velha.
      */

      Pessoa p1 = new Pessoa();
      Pessoa p2 = new Pessoa();

      Console.WriteLine("Dados da primeira pessoa:");
      Console.Write("Nome: ");
      p1.Nome = Console.ReadLine();
      Console.Write("Idade: ");
      p1.Idade = int.Parse(Console.ReadLine());

      Console.WriteLine();

      Console.WriteLine("Dados da segunda pessoa:");
      Console.Write("Nome: ");
      p2.Nome = Console.ReadLine();
      Console.Write("Idade: ");
      p2.Idade = int.Parse(Console.ReadLine());

      Console.WriteLine();

      var pessoaMaisVelha = p1.Idade > p2.Idade ? p1 : p2;
      Console.WriteLine("Pessoa mais velha: " + pessoaMaisVelha.Nome);
    }
  }
}
