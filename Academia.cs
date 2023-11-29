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
    }
}
