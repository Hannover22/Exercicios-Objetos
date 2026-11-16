using Exercicio1;

Carro CadastrarCarro()
{
    Console.Write("Informe o fabricante: ");
    string fab = Console.ReadLine();
    Console.Write("Informe o modelo: ");
    string mod = Console.ReadLine();
    Console.Write("Informe o ano de fabricação: ");
    int anofab = int.Parse(Console.ReadLine());
    Console.Write("Informe o ano do modelo: ");
    int anomod = int.Parse(Console.ReadLine());
    Console.Write("Informe o preço: ");
    double valor = double.Parse(Console.ReadLine());
    Motor motor = new();

    Console.WriteLine("Especificações do motor: ");
    Console.Write("Combustivel: ");
    int comb = int.Parse(Console.ReadLine());
    Console.Write("Cilindradas: ");
    int cil = int.Parse(Console.ReadLine());
    Console.Write("Potencia: ");
    int pot = int.Parse(Console.ReadLine());

    motor.SetCombustivel(comb);
    motor.SetCilindradas(cil);
    motor.SetPotencia(pot);
    
    Carro c = new();

    c.SetFabricante(fab);
    c.SetModelo(mod);
    c.SetAnoFabricacao(anofab);
    c.SetAnoModelo(anomod);
    c.SetValor(valor);
    c.SetMotor(motor);

    return c;
}



Carro[] vetor = new Carro[4];

for(int i = 0; i < 4; i++)
{
    vetor[i] = CadastrarCarro();
    Console.Write("\n");
}

for(int i = 0; i < 4; i++)
{
    Console.WriteLine(vetor[i].ToString());
}