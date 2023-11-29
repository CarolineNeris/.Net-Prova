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

        // Exemplo de cadastro de um treinador
        metodos.CadastrarTreinador("Maria", new DateTime(1985, 9, 20), "98765432100", "123456");

        // Exibindo os cadastros realizados
        metodos.ExibirCadastros();
    }
}
