using System;
namespace Aula02
{
	public class Carro
	{
		public String nome;
		public int ano;

		public Carro()
		{

		}
		public void imprimir()
		{
			Console.WriteLine("Nome: {0} \nAno: {1}",
				nome, ano);
		}
	}

}