
public class Reserva
{
    public List<Pessoa> Hospedes { get; set; }
    Suite Suite;
    public int DiasReservados { get; set; }

    public Reserva() { } // Contrutor padrão

    public Reserva(int diasreservados) // Cosntrutor com argumentos
    {
        DiasReservados = diasreservados;
    }

    public void CasdastrarSuite()
    {
        Console.Clear();
        Suite suite;
        Console.WriteLine();
        Console.WriteLine("Cadastro de Suites...");
        Console.WriteLine("-----------------------------");

        Console.Write("Qual o tipo de suite: ");
        string tiposuite = Console.ReadLine();

        Console.Write("Qual a capacidade: ");
        int capacidade = int.Parse(Console.ReadLine());

        Console.Write("Qual o valor da diaria: ");
        decimal valordiaria = decimal.Parse(Console.ReadLine());

        suite = new Suite(tiposuite, capacidade, valordiaria);
        Suite = suite;
        Console.WriteLine("Cadastro realizado com sucesso!....");
        Thread.Sleep(3000);
        Menu();
    }

    public void CadastrarHospedes()
    {
        Console.Clear();
        List<Pessoa> hospedes = new();
        Console.WriteLine("Cadastrando Hospedes...");
        Console.WriteLine("-----------------------------");
        Console.Write("Quantos hospedes deseja cadastrar: ");
        int quantidadehospedes = int.Parse(Console.ReadLine());
        int i = 0;

        if (Suite.Capacidade >= quantidadehospedes)
        {
            while (i < quantidadehospedes)
            {
                Console.Write($"Digite o nome do {i + 1}º hospede: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o sobrenome: ");
                string sobrenome = Console.ReadLine();
                hospedes.Add(new Pessoa(nome, sobrenome));
                i++;
                Console.WriteLine("-----------------------------\n");
            }

            Console.Write("Por quantos dias deseja reserva? ");
            DiasReservados = int.Parse(Console.ReadLine());

            Hospedes = hospedes;
            Console.WriteLine("Hospedes cadastrados com sucesso!...");
            Thread.Sleep(5000);
            Menu();
        }
        else
        {
            Console.WriteLine("Não temos reserva suficiente para a quantidade de hospedes...");
            Thread.Sleep(2000);
            Menu();
        }
    }

    public void ObterQuantidadeHospedes()
    {
        Console.Clear();
        Console.WriteLine("Exibindo quantidade de hospedes cadastrados...");
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine($"Temos {Hospedes.Count} hospedes cadastrados.");
        Thread.Sleep(5000);
        Menu();
    }

    public void CalcularDiaria()
    {
        Console.Clear();
        Console.WriteLine("Exibindo o valor da diaria...");
        Console.WriteLine("-----------------------------");
        decimal valorTotalDiaria;
        valorTotalDiaria = DiasReservados * Suite.ValorDiaria;

        if (DiasReservados >= 10)
        {
            decimal valorTotalDiariaDesconto = DiasReservados * Suite.ValorDiaria * 0.1M;
            decimal desconto = valorTotalDiariaDesconto;
            valorTotalDiaria -= desconto;
        }
        Console.WriteLine($"O valor da diaria é: {valorTotalDiaria:C2}");
        Thread.Sleep(5000);
        Menu();
    }

    public void ExibirHospedes()
    {
        Console.Clear();
        Console.WriteLine("Exibindo hospedes cadastrados....\n");
        Hospedes.ForEach(h => Console.WriteLine(h.NomeCompleto));
        Console.WriteLine("Retornando ao Menu...");
        Thread.Sleep(4000);
        Menu();
    }

    public void Menu()
    {
        try
        {
            Console.Clear();
            Console.WriteLine("Selecione uma das opções...");
            Console.WriteLine("-----------------------------");
            Console.WriteLine
            (
            "\n1 -> Cadastra Suite\n2 -> Cadastrar Hospedes\n3 -> Obeter quantidade de Hospedes\n4 -> Calcular Diaria\n5 -> Exibir Hospedes\n"
            );
            Console.WriteLine("-----------------------------\n");
            Console.Write("Digite sua opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: CasdastrarSuite(); break;
                case 2: CadastrarHospedes(); break;
                case 3: ObterQuantidadeHospedes(); break;
                case 4: CalcularDiaria(); break;
                case 5: ExibirHospedes(); break;
            }
        }
        catch (System.Exception)
        {
            Console.WriteLine("Erro ao selecionar opção...");
            Console.Clear();
            Menu();
        }
    }
}