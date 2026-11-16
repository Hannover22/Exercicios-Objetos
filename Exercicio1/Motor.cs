using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1
{
    public class Motor
    {
        public int combustivel;
        public int cilindradas;
        public int potencia;

        public void SetCombustivel(int tamanho)
        {
            this.combustivel = tamanho;
        }
        public void SetCilindradas(int cilindradas)
        {
            this.cilindradas = cilindradas;
        }
        public void SetPotencia(int potencia)
        {
            this.potencia = potencia;
        }

        public int GetCombustivel()
        {
            return this.combustivel;
        }
        public int GetPotencia()
        {
            return this.potencia;
        }
        public int GetCilindradas()
        {
            return this.cilindradas;
        }

        public override string ToString()
        {
            return "Combustivel: " + combustivel + "\nCilindradas: " + cilindradas + "\nPotencia: " + potencia;
        }
    }
}
