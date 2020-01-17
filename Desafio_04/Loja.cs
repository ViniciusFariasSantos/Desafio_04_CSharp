using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_04
{
	class Loja
	{
		public String nome { get; set; }
		public String cnpj{ get; set; }
        List<Livro> livros;
        List<VideoGame> games;

		public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> games)
		{
			this.nome = nome;
			this.cnpj = cnpj;
			this.livros = livros;
			this.games = games;
		}

		public void listaLivros()
		{
			Console.WriteLine("A loja Americanas posssui estes livros para vendas \n");
			int n = livros.Count;
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine("Titulo :" + livros[i].nome + ", " + "  Preço: " + livros[i].preco + ", " + "  Quantidade: " + livros[i].qtd + "  em estoque. \n ");

			}
			Console.WriteLine("-------------------------------------------------");


		}
		public void ListaVideoGames()
		{
			Console.WriteLine("A loja Americanas posssui estes Videos-games para vendas \n");
			int n = games.Count;
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine("Titulo :" + games[i].nome + ", " + "  Preço: " + games[i].preco + ", " + "  Quantidade: " + games[i].qtd + "  em estoque. \n ");


			}
			Console.WriteLine("-------------------------------------------------");

		}



		public double calculaPatrimonio()
		{



			double n = games.Count;
			double a = livros.Count;
			double result = 0;
			double resulta = 0;

			for (int i = 0; i < n; i++)
			{
				result += (int)games[i].preco * games[i].qtd;
			}

			for (int i = 0; i < a; i++)
			{

				resulta += (int)livros[i].preco * livros[i].qtd;

			}
			Console.WriteLine("Total de patrimonio referente ao livro :  " + resulta);
			Console.WriteLine("Total de patrimonio referente ao Video-games :  " + result);
			Console.WriteLine("O Patrimonio da loja  " + this.nome + " é " + (resulta + result));

			return (0);



		}

	}
}
