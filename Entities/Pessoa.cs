
public class Pessoa
{
    public string Nome { get; set; }
    public string SobreNome { get; set; }
    public string NomeCompleto => $"{Nome} {SobreNome}".ToUpper();

    public Pessoa() { }

    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome;
        SobreNome = sobrenome;
    }
}