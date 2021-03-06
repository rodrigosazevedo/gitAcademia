using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAvaliativo
{
    internal class Persistencia
    {        
        /// Função utilizada para ler o arquivo .dat ao abrir o programa e popular a lista que será 
        /// utilizada durante a execução.
        public static void lerArquivoVeiculosEntrada(List<Veiculo> listaVeiculos) 
        {
            StreamReader leitorArquivo = new StreamReader("veiculosEntrada.dat");
            string linhaArquivo;
            string[] vetorDados;

            //Caso o arquivo esteja vazio (para evitar erros)
            if (leitorArquivo.EndOfStream)
            {
                leitorArquivo.Close();
                return;
            }

            do
            {
                linhaArquivo = leitorArquivo.ReadLine();
                vetorDados = linhaArquivo.Split(';');
                listaVeiculos.Add(new Veiculo(vetorDados[0], DateTime.Parse(vetorDados[1]), TimeSpan.Parse(vetorDados[2])));
            } while (!leitorArquivo.EndOfStream);

            leitorArquivo.Close();
        }

        /// Função utilizada para ler o arquivo .dat ao abrir o programa e popular a lista que será 
        /// utilizada durante a execução.
        public static void lerArquivoVeiculosSaida(List<Veiculo> listaVeiculos) 
        {
            StreamReader leitorArquivo = new StreamReader("veiculosSaida.dat");
            string linhaArquivo;
            string[] vetorDados;

            //Caso o arquivo esteja vazio (para evitar erros)
            if (leitorArquivo.EndOfStream)
            {
                leitorArquivo.Close();
                return;
            }

            do
            {
                linhaArquivo = leitorArquivo.ReadLine();
                vetorDados = linhaArquivo.Split(';');
                listaVeiculos.Add(new Veiculo(vetorDados[0], DateTime.Parse(vetorDados[1]), TimeSpan.Parse(vetorDados[2])));
                listaVeiculos.Last().DataSaida = DateTime.Parse(vetorDados[3]);
                listaVeiculos.Last().HoraSaida = TimeSpan.Parse(vetorDados[4]);
                listaVeiculos.Last().TempoPermanencia = int.Parse(vetorDados[5]);
                listaVeiculos.Last().ValorCobrado = double.Parse(vetorDados[6]);
            } while (!leitorArquivo.EndOfStream);
            leitorArquivo.Close();

        }

        /// Função utilizada para transferir o conteúdo da lista de objetos para o arquivo .dat, 
        /// para a próxima vez que o programa for aberto
        public static void gravarArquivoVeiculosEntrada(List<Veiculo> listaVeiculos) 
        {
            StreamWriter escritorArquivo = new StreamWriter("veiculosEntrada.dat");

            foreach(Veiculo veiculo in listaVeiculos)
            {
                escritorArquivo.WriteLine(veiculo.PlacaVeiculo + ";" + veiculo.DataEntrada + ";" + veiculo.HoraEntrada);
                escritorArquivo.Flush();
            }

            escritorArquivo.Close();
        }

        /// Função utilizada para transferir o conteúdo da lista de objetos para o arquivo .dat, 
        /// para a próxima vez que o programa for aberto
        public static void gravarArquivoVeiculosSaida(List<Veiculo> listaVeiculos) 
        {
            StreamWriter escritorArquivo = new StreamWriter("veiculosSaida.dat");

            foreach(Veiculo veiculo in listaVeiculos)
            {
                escritorArquivo.WriteLine(veiculo.PlacaVeiculo + ";" + veiculo.DataEntrada + ";" + veiculo.HoraEntrada +
                                          ";" + veiculo.DataSaida + ";" + veiculo.HoraSaida + ";" + veiculo.TempoPermanencia +
                                          ";" + veiculo.ValorCobrado);
                escritorArquivo.Flush();
            }

            escritorArquivo.Close();
        
        }
    }
}
