using System;
using Pessoas; // Importando o namespace onde as classes Pessoa, Cliente e Treinador estão definidas
using Academia; // Importando o namespace onde a classe Metodos está definida

class Program
{
    static void Main()
    {
        Metodos metodos = new Metodos(); // Instanciando a classe Metodos para utilizarmos seus métodos

        // Exemplo de cadastro de um cliente
        metodos.CadastrarCliente("João", new DateTime(1990, 5, 15), "12345678900", 1.75, 70.5);
        /*metodos.CadastrarCliente("Betinho do Flamengo", new DateTime(1985,10,15), "452167215963", 1.80, 86.6);
        metodos.CadastrarCliente("Maria Fernanda", new DateTime(1992, 3, 22), "98765432101", 1.70, 60.2);
        metodos.CadastrarCliente("Lucas Oliveira", new DateTime(1988, 7, 10), "12345678902", 1.85, 80.5);
        metodos.CadastrarCliente("Ana Carolina, a cantora", new DateTime(1995, 9, 5), "45612378903", 1.65, 55.8);
        metodos.CadastrarCliente("Rafaela Silva", new DateTime(1987, 12, 30), "78912345604", 1.75, 70.0);
        metodos.CadastrarCliente("João da Silva", new DateTime(1990, 5, 5), "12378945605", 1.80, 85.3);*/


        // Exemplo de cadastro de um treinador
        metodos.CadastrarTreinador("Maria", new DateTime(1985, 9, 20), "98765432100", "123456");
        /*metodos.CadastrarTreinador("Ana", new DateTime(1992, 1, 10), "12345678901", "654321");
        metodos.CadastrarTreinador("Pedro", new DateTime(1980, 4, 5), "98765432109", "987654");
        metodos.CadastrarTreinador("Mariana", new DateTime(1975, 8, 15), "12312312312", "111222");
        metodos.CadastrarTreinador("Rafael", new DateTime(1987, 12, 25), "45678912356", "987123");
        metodos.CadastrarTreinador("Isabela", new DateTime(1990, 7, 3), "98765432100", "123123");*/


        // Exibindo os cadastros realizados
        metodos.ExibirCadastros();

        metodos.RelatorioTreinadoresPorIdade(25,40);

        metodos.RelatorioClientesPorIdade(20,50);

        metodos.RelatorioClientesPorIMC(25.0);

        metodos.RelatorioClientesOrdemAlfabetica();

        metodos.RelatorioClientesPorIdade();

        metodos.RelatorioAniversariantesDoMes(9);
    }
}
