using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    internal class Pessoa
    {
        public string? Name { get; set; }
        public string Endereco { get; set; }
        public DateOnly data { get; set; }

        public string Hello()
        {
            return "Olá mundo";
        }
    }
}
