
public class Suite
{
    public string TipoSuite { get; set; }
    public int Capacidade { get; set; }
    public decimal ValorDiaria { get; set; }
    public Suite() { }
    public Suite(string tiposuite, int capacidade = 0, decimal valordiaria = 0M)
    {
        TipoSuite = tiposuite;
        Capacidade = capacidade;
        ValorDiaria = valordiaria;
    }
}