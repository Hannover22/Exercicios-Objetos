using Exercicio3;
int x = 0;

while(x == 0)
{
    Console.WriteLine("Informe quantos livros voce quer guardar: ");
    x = int.Parse(Console.ReadLine());
    if (x <= 0) x = 0;
}

Livro[] livros = new Livro[x];

Livro CadastrarLivro()
{
    Console.WriteLine("Informe o titulo do livro: ");
    string titulo = Console.ReadLine();
    Console.WriteLine("Informe o autor do livro: ");
    string autor = Console.ReadLine();
    uint paginas = 0;
    while (paginas <= 0)
    {
        Console.WriteLine("Informe a quantidade de páginas do livro: ");
        paginas = uint.Parse(Console.ReadLine());
    }

    return new Livro(titulo, autor, paginas);
}

Livro[] MontarEstanteDeLivros()
{
    Livro[] livros = new Livro[x];
    for(int i = 0; i < livros.Length; i++)
    {
        livros[i] = CadastrarLivro();
    }
    return livros;
}

void MostrarEstanteDeLivros(Livro[] books)
{
    for(int i = 0; i < books.Length; i++)
    {
        Console.WriteLine(books[i]);
    }
}

MostrarEstanteDeLivros(MontarEstanteDeLivros());