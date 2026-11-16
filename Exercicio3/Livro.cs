using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3
{
    internal class Livro
    {
        public string titulo;
        public string autor;
        public int paginas;

        public Livro(string titulo, string autor, int paginas)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.paginas = paginas;
        }

        public string GetTitulo()
        {
            return this.titulo;
        }
        public string GetAutor()
        {
            return this.autor;
        }
        public int GetPaginas()
        {
            return this.paginas;
        }

        public override string ToString()
        {
            return "Titulo: " + titulo + "\nAutor: " + autor + "\nPaginas: " + paginas;
        }
    }
}
