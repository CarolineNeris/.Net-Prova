namespace academia;

class Pessoa 
{
    public string Nome {get; set;}
    private DateTime dataNascimento;
    public DateTime DataNascimento
    {
        get => dataNascimento;
        set
        {
            // Verifica se a data de nascimento está no passado (não futura)
            if (value < DateTime.Now)
            {
                dataNascimento = value;
            }
            else
            {
                throw new ArgumentException("Data de nascimento inválida.");
            }
        }
    }
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
}

class Treinador : Pessoa
{
  private string cref;  
  public string CREF
    {
        get => cref;
        set
        {
            // Condição para validar o formato do CREF (por exemplo, deve ter 6 dígitos)
            if (value.Length == 6 && !crefs.Contains(value))
            {
                cref = value;
                crefs.Add(value);
            }
            else
            {
                throw new ArgumentException("CREF inválido ou já existente.");
            }
        }
    }
}



class Cliente : Pessoa
{
    private double altura;
    public double Altura
    {
        get => altura;
        set
        {
            if (value >= 0)
            {
                altura = value;
            }
            else
            {
                throw new ArgumentException("Altura não pode ser negativa.");
            }
        }
    }

    private double peso;
    public double Peso
    {
        get => peso;
        set
        {
            if (value >= 0)
            {
                peso = value;
            }
            else
            {
                throw new ArgumentException("Peso não pode ser negativo.");
            }
        }
    }
}
