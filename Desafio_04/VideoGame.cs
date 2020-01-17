using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_04
{
    class VideoGame : Produto
    {
        String marca;
        String modelo;
        bool isUsado;

        public VideoGame(string nome, double preco, int qtd, string marca, string modelo, bool isUsado) : base(nome, preco, qtd)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.isUsado = isUsado; 
        }

        public double calculeImposto()
        {
            if (isUsado == true)
            {
                double novoPreco = preco * 0.25;
                Console.WriteLine("Imposto " + nome + marca + modelo + "  R$ : " + novoPreco);
                return (0);
            }
            else
            {
                double novoPreco = preco * 0.45;

                Console.WriteLine("Imposto " + nome + marca + modelo + "  R$  : " + novoPreco);
                Console.WriteLine("-------------------------------");

                return (0);
            }
        }

    }

}
