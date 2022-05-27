using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    class Veiculo
    {
        string placa;
        DateTime dataHoraEntrada;

        public Veiculo(string placa, DateTime dataHoraEntrada)
        {
            this.placa = placa;
            this.dataHoraEntrada = dataHoraEntrada;
        }

        public string Placa { get => placa; set => placa = value; }
        public DateTime DataHoraEntrada { get => dataHoraEntrada; set => dataHoraEntrada = value; }
    }
}
