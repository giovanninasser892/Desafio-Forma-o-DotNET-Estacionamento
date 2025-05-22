using System.ComponentModel;
using System.Security.Cryptography;
using System;

Console.WriteLine("Digite o Preço Inicial");
int precoinicial = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o Preço por Hora");
int precoporhora = Convert.ToInt32(Console.ReadLine());

List<string> PlacaDoVeiculo = new List<string>();
string placa = String.Empty;
List<int> horas = new List<int>();
int numero = 0;
do
{
  Console.WriteLine("1- Cadastrar Veiculo");
  Console.WriteLine("2- Remover Veiculo");
  Console.WriteLine("3- Listar Veiculos");
  Console.WriteLine("4- Encerrar");
  Console.WriteLine("Digite uma Opção");
  numero = Convert.ToInt32(Console.ReadLine());
  switch (numero)
  {
    case 1:
      Console.WriteLine("Qual a Placa do Veiculo?");
      placa = Console.ReadLine();
      PlacaDoVeiculo.Add(placa);
      Console.WriteLine("Quantas horas o veiculo permaneceu estacionado?");
      horas.Add(Convert.ToInt32(Console.ReadLine())); 
      Console.Clear();
      break;

    case 2:
      int quantidadedehoras = horas[PlacaDoVeiculo.IndexOf(placa)];
      Console.WriteLine("Qual a Placa do Veiculo?");
      string placaremover = Console.ReadLine();
      if (PlacaDoVeiculo.Contains(placaremover))
      {
        PlacaDoVeiculo.Remove(placa);
        Console.WriteLine($"O Veiculo {placa} foi removido e o preço total foi de:  {(quantidadedehoras*precoporhora) + precoinicial}");
      }
      else
      {
        Console.WriteLine("Placa não encontrada");
      }
      Console.WriteLine("Pressione qualquer tecla para continuar...");
      Console.ReadKey();
      Console.Clear();
      break;

    case 3:
      for (int i = 0; i < PlacaDoVeiculo.Count; i++)
      {
         Console.WriteLine($"- {PlacaDoVeiculo[i]}");
      }
      Console.WriteLine("Pressione qualquer tecla para continuar...");
      Console.ReadKey();
      Console.Clear();
      break;

    case 4:
      Console.WriteLine("Saindo do sistema...");
      Thread.Sleep(1500);
      Console.Clear();
      break;

    default:
      Console.WriteLine("Opção inválida.");
      break;
  }
} while (numero != 4);
  