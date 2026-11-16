using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1
{
    public class Carro
    {
        public string fabricante;
        public string modelo;
        public Motor motor;
        public int anoFabricacao;
        public int anoModelo;
        public double valor;
        public double IPVA;
       

        public override string ToString()
        {
            return "Fabricante: " + this.fabricante + "\nModelo: " +
                this.modelo + "\nAno de fabricação: " + this.anoFabricacao +
                "\nAno do modelo: " + this.anoModelo + "\nValor: " +
                this.valor + "\nIPVA: " + IPVA + "\nMotor: " + motor.ToString();
        }

        public void CalculaIPVA()
        {
            if(2026 - anoFabricacao > 20)
            {
                this.IPVA = 0;
            }
            else
            {
                this.IPVA = this.valor * 0.04; 
            }
        }
        public void SetMotor(Motor motor)
        {
            this.motor = motor;
        }
        public void SetFabricante(string fabricante)
        {
            this.fabricante = fabricante;
        }
        
        public void SetModelo(string modelo)
        {
            this.modelo = modelo;
        }

        public void SetAnoFabricacao(int ano)
        {
            this.anoFabricacao = ano;
        }

        public void SetAnoModelo(int ano)
        {
            this.anoModelo = ano;
        }

        public void SetValor(double valor)
        {
            this.valor = valor;
        }

        public string GetFabricante()
        {
            return fabricante;
        }

        public string GetModelo()
        {
            return modelo;
        }

        public int GetAnoFabricacao()
        {
            return anoFabricacao;
        }

        public int GetAnoModelo()
        {
            return anoModelo;
        }

        public double GetValor()
        {
            return valor;
        }
    }
}
