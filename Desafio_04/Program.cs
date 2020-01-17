using System;
using System.Collections;
using System.Collections.Generic;

namespace Desafio_04
{
	class Program
	{
		static void Main(string[] args)
		{

			Livro l1 = new Livro("Harry Potter", 40, 50, "J.K.Rowling", "fantasia", 300);
			Livro l2 = new Livro("Senhor dos Anéis", 60, 30, "J.R.R.Tolkien", "fantasia", 500);
			Livro l3 = new Livro("Java POO", 20, 50, "GFT", "educativo", 500);

			VideoGame ps4 = new VideoGame("PS4", 1800, 100, "Sony", "Slim", false);
			VideoGame ps4Usado = new VideoGame("PS4", 1000, 7, "Sony", "Slim", true);
			VideoGame xbox = new VideoGame("XBOX", 1500, 500, "Microsoft", "one", false);

			List<Livro> livros = new List<Livro>
			{
				l1,
				l2,
				l3
			};



			List<VideoGame> games = new List<VideoGame>
			{


			ps4,
			ps4Usado,
			xbox

			};

			Loja americanas = new Loja("Americanas", "12345678", livros, games);
			l2.calculeImposto();
			l3.calculeImposto();

			ps4Usado.calculeImposto();
			ps4.calculeImposto();

			americanas.listaLivros();
			americanas.ListaVideoGames();
			americanas.calculaPatrimonio();
		}
	}
}
