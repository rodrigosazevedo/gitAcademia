using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAvaliativo
{
    internal class Veiculo
    {
        string placaVeiculo;
        DateTime dataEntrada;
        TimeSpan horaEntrada;
        DateTime dataSaida;
        TimeSpan horaSaida;
        int tempoPermanencia;
        double valorCobrado;


        public Veiculo(string placaVeiculo, DateTime dataEntrada, TimeSpan horaEntrada)
        {
            this.placaVeiculo = placaVeiculo;
            this.dataEntrada = dataEntrada;
            this.horaEntrada = horaEntrada;
        }

        public string PlacaVeiculo { get => placaVeiculo; set => placaVeiculo = value; }
        public DateTime DataEntrada { get => dataEntrada; set => dataEntrada = value; }
        public TimeSpan HoraEntrada { get => horaEntrada; set => horaEntrada = value; }
        public int TempoPermanencia { get => tempoPermanencia; set => tempoPermanencia = value; }
        public double ValorCobrado { get => valorCobrado; set => valorCobrado = value; }
        public DateTime DataSaida { get => dataSaida; set => dataSaida = value; }
        public TimeSpan HoraSaida { get => horaSaida; set => horaSaida = value; }

        public static bool jaCadastrado(string placa, List<Veiculo> lista)
        {
            foreach (Veiculo veiculo in lista)
            {
                if (placa.Equals(veiculo.placaVeiculo))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
