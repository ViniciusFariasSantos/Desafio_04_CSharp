using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_04
{
    abstract class Produto
    {
        public String nome { get; set; }
        public double preco { get; set; }
        public int qtd { get; set; }


        protected Produto(string nome, double preco, int qtd)
        {
            this.nome = nome;
            this.preco = preco;
            this.qtd = qtd;
        }
    }
}
