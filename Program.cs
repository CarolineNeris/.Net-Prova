using Sytem;
using academia;
using Sytem.Collections.Generic


    class Program
    {
        static void Main(string[] args)
        {
            Academia academia = new Academia();

            // Adicionando treinadores
            Treinador treinador1 = new Treinador
            {
                Nome = "João Silva",
                DataNascimento = new DateTime(1985, 5, 15),
                CPF = "12345678901",
                CREF = "ABC123"
            };

            Treinador treinador2 = new Treinador
            {
                Nome = "Maria Santos",
                DataNascimento = new DateTime(1990, 10, 25),
                CPF = "98765432109",
                CREF = "DEF456"
            };

            academia.AdicionarTreinador(treinador1);
            academia.AdicionarTreinador(treinador2);

            // Adicionando clientes
            Cliente cliente1 = new Cliente
            {
                Nome = "Pedro Souza",
                DataNascimento = new DateTime(1998, 3, 8),
                CPF = "11122233344",
                Altura = 1.75,
                Peso = 70
            };

            Cliente cliente2 = new Cliente
            {
                Nome = "Ana Oliveira",
                DataNascimento = new DateTime(1995, 12, 12),
                CPF = "55566677788",
                Altura = 1.60,
                Peso = 55
            };

            academia.AdicionarCliente(cliente1);
            academia.AdicionarCliente(cliente2);
        }
    }
}
