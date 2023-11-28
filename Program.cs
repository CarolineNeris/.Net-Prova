using Sytem;
usin Sytem.Collections.Generic

class Pessoa 
{
    public string Nome {get; set;}
    public DateTime DataNascimento {get; set}
    public CPF {get; set;}
}

class Treinador : Pessoa
{
    private static readonly HashSet<string> cpfs = new HashSet<string>();

    private string cpf;

    public string CPF
    {
        get => cpf;
        set
        {
            if (value.Length == 11 && !cpfs.Contains(value))
            {
                cpf = value;
                cpfs.Add(value);
            }
            else
            {
                throw new ArgumentException("CPF inválido ou já existente.");
            }
        }
    }

    // Restante da classe...
}

class Cliente : Pessoa
{
    private static readonly HashSet<string> cpfs = new HashSet<string>();

    private string cpf;

    public string CPF
    {
        get => cpf;
        set
        {
            if (value.Length == 11 && !cpfs.Contains(value))
            {
                cpf = value;
                cpfs.Add(value);
            }
            else
            {
                throw new ArgumentException("CPF inválido ou já existente.");
            }
        }
    }

    // Restante da classe...
}
