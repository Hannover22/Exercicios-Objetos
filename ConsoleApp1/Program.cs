using Exercicio2;

ContaBancaria conta = new();

Console.Write("Digite o nome do titular da conta: ");
conta.SetTitular(Console.ReadLine());
int opcao = 0;
while (true) {
    Console.WriteLine("\n1 - Depositar \n2 - Sacar \n3 - Exibir saldo \n4 - Mostrar dados \n5 - Sair");
    opcao = int.Parse(Console.ReadLine());
    switch (opcao) {
        case 1:
            Console.WriteLine("Digite o quanto você deseja depositar: ");
            conta.Depositar(double.Parse(Console.ReadLine()));
            Console.WriteLine("O saldo atual da sua conta é de: " + conta.ExibirSaldo());
            continue;

        case 2:
            Console.WriteLine("Digite o quanto você deseja sacar: ");
            conta.Sacar(double.Parse(Console.ReadLine()));
            Console.WriteLine("O saldo atual da sua conta é de: " + conta.ExibirSaldo());
            continue;

        case 3:
            Console.WriteLine("O seu saldo é de: " + conta.ExibirSaldo());
            continue;

        case 4:
            Console.WriteLine(conta.ToString());
            continue;

        case 5:
            Console.WriteLine("Até mais.");
            break;
    }
}