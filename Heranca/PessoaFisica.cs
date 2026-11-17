using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    internal class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }
        public void TransformarNome()
        {
            Name = Name.ToUpper();
        }
    }
}
