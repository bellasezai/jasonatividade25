
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Aula230625
{
    public class Estacionamento
    {
        public string Proprietario { get; set; }
        public List<Veiculo> Veiculos { get; set; } = new List<Veiculo>();

        public void AdicionarVeiculo(Veiculo veiculo)
        {
            Veiculos.Add(veiculo);
        }

        public List<Veiculo> ListarVeiculos()
        {
            return Veiculos;
        }

        public void SalvarEmJson(string caminhoArquivo)
        {
            var json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(caminhoArquivo, json);
        }

        public static Estacionamento CarregarDeJson(string caminhoArquivo)
        {
            var json = File.ReadAllText(caminhoArquivo);
            return JsonSerializer.Deserialize<Estacionamento>(json);
        }
    }

    public class Veiculo
    {
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
    }
}
