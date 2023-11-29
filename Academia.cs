using System;
using System.Collections.Generic;
using Pessoas;


namespace Academia
{
    class Metodos
    {
        protected List<(object pessoa, string tipo)> cadastros = new List<(object, string)>();

        public void CadastrarCliente(string nome, DateTime dataNascimento, string cpf, double altura, double peso)
        {
            Cliente cliente = new Cliente
            {
                Nome = nome,
                DataNascimento = dataNascimento,
                CPF = cpf,
                Altura = altura,
                Peso = peso
            };

            cadastros.Add((cliente, "Cliente"));
        }

        public void CadastrarTreinador(string nome, DateTime dataNascimento, string cpf, string cref)
        {
            Treinador treinador = new Treinador
            {
                Nome = nome,
                DataNascimento = dataNascimento,
                CPF = cpf,
                CREF = cref
            };

            cadastros.Add((treinador, "Treinador"));
        }

        public void ExibirCadastros()
        {
            foreach (var cadastro in cadastros)
            {
                Console.WriteLine($"Tipo: {cadastro.tipo}");

                if (cadastro.tipo == "Cliente")
                {
                    var cliente = (Cliente)cadastro.pessoa;
                    ExibirDetalhesCliente(cliente);
                }
                else if (cadastro.tipo == "Treinador")
                {
                    var treinador = (Treinador)cadastro.pessoa;
                    ExibirDetalhesTreinador(treinador);
                }

                Console.WriteLine();
            }
        }

        private void ExibirDetalhesCliente(Cliente cliente)
        {
            Console.WriteLine($"Nome: {cliente.Nome}");
            Console.WriteLine($"Data de Nascimento: {cliente.DataNascimento}");
            Console.WriteLine($"CPF: {cliente.CPF}");
            Console.WriteLine($"Altura: {cliente.Altura}");
            Console.WriteLine($"Peso: {cliente.Peso}");
        }

        private void ExibirDetalhesTreinador(Treinador treinador)
        {
            Console.WriteLine($"Nome: {treinador.Nome}");
            Console.WriteLine($"Data de Nascimento: {treinador.DataNascimento}");
            Console.WriteLine($"CPF: {treinador.CPF}");
            Console.WriteLine($"CREF: {treinador.CREF}");
        }

        //Relatórios 
        //relatório treinador por idade
        public void RelatorioTreinadoresPorIdade(int idadeMinima, int idadeMaxima)
        {
            DateTime hoje = DateTime.Today;

            var treinadoresFiltrados = cadastros
                .Where(cadastro => cadastro.tipo == "Treinador")
                .Select(cadastro => (Treinador)cadastro.pessoa)
                .Where(treinador =>
                    hoje.Year - treinador.DataNascimento.Year >= idadeMinima &&
                    hoje.Year - treinador.DataNascimento.Year <= idadeMaxima
                );

            Console.WriteLine($"Relatório de Treinadores com idade entre {idadeMinima} e {idadeMaxima} anos:");
            foreach (var treinador in treinadoresFiltrados)
            {
                ExibirDetalhesTreinador(treinador);
            }
        }
        //relatorio cliente por idade
        public void RelatorioClientesPorIdade(int idadeMinima, int idadeMaxima)
        {
            Console.WriteLine("Relatório de Clientes por Idade:");
            DateTime dataAtual = DateTime.Today;

            var clientesFiltrados = cadastros
                .Where(cadastro => cadastro.tipo == "Cliente" && cadastro.pessoa is Cliente)
                .Select(cadastro => (Cliente)cadastro.pessoa)
                .Where(cliente =>
                    (dataAtual - cliente.DataNascimento).Days / 365 >= idadeMinima &&
                    (dataAtual - cliente.DataNascimento).Days / 365 <= idadeMaxima);

            foreach (var cliente in clientesFiltrados)
            {
                ExibirDetalhesCliente(cliente);
            }
        }
        public void RelatorioClientesPorIMC(double valorIMC)
        {
            Console.WriteLine("Relatório de Clientes por IMC:");
            var clientesFiltrados = cadastros
                .Where(cadastro => cadastro.tipo == "Cliente" && cadastro.pessoa is Cliente)
                .Select(cadastro => (Cliente)cadastro.pessoa)
                .Where(cliente =>
                {
                    if (cliente.Altura != 0)
                    {
                        double imc = cliente.Peso / (cliente.Altura * cliente.Altura);
                        return imc > valorIMC;
                    }
                    return false;
                })
                .OrderBy(cliente =>
                {
                    if (cliente.Altura != 0)
                    {
                        return cliente.Peso / (cliente.Altura * cliente.Altura);
                    }
                    return 0;
                });

            foreach (var cliente in clientesFiltrados)
            {
                ExibirDetalhesCliente(cliente);
            }
        }
        public void RelatorioClientesOrdemAlfabetica()
        {
            Console.WriteLine("Relatório de Clientes em Ordem Alfabética:");
            var clientesOrdenados = cadastros
                .Where(cadastro => cadastro.tipo == "Cliente" && cadastro.pessoa is Cliente)
                .Select(cadastro => (Cliente)cadastro.pessoa)
                .OrderBy(cliente => cliente.Nome);

            foreach (var cliente in clientesOrdenados)
            {
                ExibirDetalhesCliente(cliente);
            }
        }
        public void RelatorioClientesPorIdade()
        {
            Console.WriteLine("Relatório de Clientes do Mais Velho para o Mais Novo:");
            var clientesFiltrados = cadastros
                .Where(cadastro => cadastro.tipo == "Cliente" && cadastro.pessoa is Cliente)
                .Select(cadastro => (Cliente)cadastro.pessoa)
                .OrderByDescending(cliente => DateTime.Now.Year - cliente.DataNascimento.Year);

            foreach (var cliente in clientesFiltrados)
            {
                ExibirDetalhesCliente(cliente);
            }
        }
        public void RelatorioAniversariantesDoMes(int mes)
        {
            Console.WriteLine($"Relatório de Aniversariantes do Mês {mes}:");
            var aniversariantes = cadastros
                .Where(cadastro => (cadastro.tipo == "Cliente" || cadastro.tipo == "Treinador") && cadastro.pessoa is Pessoa)
                .Select(cadastro => (Pessoa)cadastro.pessoa)
                .Where(pessoa => pessoa.DataNascimento.Month == mes);

            foreach (var pessoa in aniversariantes)
            {
                if (pessoa is Cliente)
                {
                    ExibirDetalhesCliente((Cliente)pessoa);
                }
                else if (pessoa is Treinador)
                {
                    ExibirDetalhesTreinador((Treinador)pessoa);
                }
            }
        }

    }
}
