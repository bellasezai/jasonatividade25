using System;
using Aula230625;


Estacionamento estacionamento = new Estacionamento
{
   Proprietario = "João"
};

estacionamento.AdicionarVeiculo(new Veiculo { Modelo = "Fusca", Placa = "ABC1234", Cor = "Azul" });
estacionamento.AdicionarVeiculo(new Veiculo { Modelo = "Civic", Placa = "XYZ5678", Cor = "Preto" });

string caminho = "estacionamento.json";
estacionamento.SalvarEmJson(caminho);



var carregado = Estacionamento.CarregarDeJson(caminho);
Console.WriteLine($"Dono: {carregado.Proprietario}");
foreach (var v in carregado.ListarVeiculos())
{
     Console.WriteLine($"{v.Modelo} - {v.Placa} - {v.Cor}");
}
             


