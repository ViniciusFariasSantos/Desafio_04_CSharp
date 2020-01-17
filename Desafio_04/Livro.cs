using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_04
{
    class Livro : Produto
    {

        String autor;
        String tema;
        int qtdPag;

        public Livro(string nome, double preco, int qtd, string autor, string tema, int qtdPag) : base (nome, preco, qtd)
        {
            this.autor = autor;
            this.tema = tema;
            this.qtdPag = qtdPag;
        }

        public double calculeImposto()
        {

            if (tema == "educativo")
            {
                Console.WriteLine("Livro educativo não tem imposto :  " + nome);
                return (0);

            }
            else
            {
                double novoPreco = preco * 0.10;
                Console.WriteLine("R$: " + novoPreco + " de impostos sobre o livro " + nome);
                return (0);
            }
        }

    }
}
