int Calculadora(int vitorias, int derrotas)
{
   return vitorias - derrotas;
}

bool sair = false;
do
{
    Console.WriteLine("Digite o número de vitórias");
    int vitorias = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o número de derrotas");
    int derrotas = int.Parse(Console.ReadLine());

    int saldo = Calculadora(vitorias, derrotas);

    switch (saldo)
    {
        case <= 10:
            Console.WriteLine($"O Herói tem de saldo de {saldo} está no nível de Ferro");
            break;
        case >=11 and <= 20:
            Console.WriteLine($"O Herói tem de saldo de {saldo} está no nível de Bronze");
            break;
        case >= 21 and <= 50:
            Console.WriteLine($"O Herói tem de saldo de {saldo} está no nível de Prata");
            break;
        case >= 51 and <= 80:
            Console.WriteLine($"O Herói tem de saldo de {saldo} está no nível de Ouro");
            break;
        case >= 81 and <= 90:
            Console.WriteLine($"O Herói tem de saldo de {saldo} está no nível de Diamante");
            break;
        case >= 91 and <= 100:
            Console.WriteLine($"O Herói tem de saldo de {saldo} está no nível de Lendário");
            break;
        case >= 101:
            Console.WriteLine($"O Herói tem de saldo de {saldo} está no nível de Imortal");
            break;
    }

    Console.WriteLine("Deseja repetir o calculo da rankeada? (Responda com S ou N)");
    string repeticao = Console.ReadLine();
    List<string> possibilidades = ["S", "s", "Sim", "sim"];

    if (!possibilidades.Contains(repeticao))
    {
        sair = true;
    }

    Console.Clear();

} while (!sair);