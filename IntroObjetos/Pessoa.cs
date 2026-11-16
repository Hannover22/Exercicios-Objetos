using System;
using System.Collections.Generic;
using System.Text;

namespace IntroObjetos
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;
        public char Sexo;

        public Pessoa(string nome, int idade, char sexo)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Sexo = sexo;
        }

        public void SetNome(string nome)
        {
            this.Nome = nome;
        }

        public string GetNome()
        {
            return Nome;
        }
        public override string ToString()
        {
            return "Nome: " + Nome + "\nIdade: " + Idade + "\nSexo: " + Sexo;
        }
    }
}
