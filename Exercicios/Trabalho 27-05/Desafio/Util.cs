using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    class Util
    {
        public static void exibirLista(string fraseExibir, List<Veiculo> listaVeiculos)
        {
            Console.WriteLine(fraseExibir);
            foreach (Veiculo i in listaVeiculos)
            {
                Console.WriteLine("Placa do veículo: " + i.Placa + " | Data/Hora Entrada: " + i.DataHoraEntrada);
            }
        }

        public static void carregarLista(List<Veiculo> listaVeiculos)
        {
            StreamReader leitorArquivo;
            string nomeArquivo = "garagem.dat";
            string[] vetorDados;
            try
            {
                leitorArquivo = new StreamReader(nomeArquivo);
                do
                {
                    vetorDados = leitorArquivo.ReadLine().Split(";");
                    listaVeiculos.Add(new Veiculo(vetorDados[0], DateTime.Parse(vetorDados[1])));
                } while (!leitorArquivo.EndOfStream);
            }
            catch (Exception e)
            {
                Console.WriteLine("Arquivo de veículos com problemas ou inexistente!");
            }
        }

        private static bool jaCadastrado(Veiculo objetoVeiculo, List<Veiculo> listaVeiculos)
        {
            foreach (Veiculo i in listaVeiculos)
            {
                if (objetoVeiculo.Placa.Equals(i.Placa))
                {
                    return true;
                }
            }
            return false;
        }

        private static void gravarArquivo(Veiculo objetoVeiculo)
        {
            try
            {
                StreamWriter escritorArquivo = new StreamWriter("garagem.dat", true);

                escritorArquivo.WriteLine(objetoVeiculo.Placa + ";" + objetoVeiculo.DataHoraEntrada);
                escritorArquivo.Flush();
                escritorArquivo.Close();
            }   catch (Exception e)
            {
                Console.WriteLine("Arquivo de veículos com problemas!");
            }
        }

        public static void cadastrarVeiculo(string fraseExibir, List<Veiculo> listaVeiculos)
        {
            Console.WriteLine(fraseExibir);
            string placaCarro;

            do
            {
                Console.Write("Digite a placa do veículo: ");
                placaCarro = Console.ReadLine();
                if (placaCarro.Length == 7)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Placa inválida!");
                }
            } while (true);

            DateTime dataHora = DateTime.Now;

            Veiculo objetoVeiculo = new Veiculo(placaCarro,dataHora);

            if (!Util.jaCadastrado(objetoVeiculo, listaVeiculos))
            {
                listaVeiculos.Add(objetoVeiculo);
                Util.gravarArquivo(objetoVeiculo);
            }
            else
            {
                Console.WriteLine("Veículo com essa placa já está cadastrado na garagem!");
            }
        }

    }
}
