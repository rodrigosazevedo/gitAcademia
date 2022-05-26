namespace Exercicio2
{
    internal class Animal
    {
        string nome;
        string tipo;


        public Animal(string nome, string tipo) 
        {
            this.nome = nome;
            this.tipo = tipo;
        }

        public string Nome { get => this.nome; set => this.nome = value; }

        public string Tipo { get => this.tipo; set => this.tipo = value;}

        public static string ContarAnimais(List<Animal> Lista)
        {
            int quantidadeGatos = 0;
            int quantidadeCachorros = 0;
            int quantidadePeixes = 0;

            foreach (Animal i in Lista)
            {
                switch (i.Tipo)
                {
                    case "GATO":
                        quantidadeGatos++;
                        break;
                    case "CACHORRO":
                        quantidadeCachorros++;
                        break;
                    case "PEIXE":
                        quantidadePeixes++;
                        break;
                }

            }

            return "Quantidade de cada animal => GATOS: " + quantidadeGatos + " CACHORROS: " +
            quantidadeCachorros + " PEIXES: " + quantidadePeixes;
        }
       
                               
    }

    
}
