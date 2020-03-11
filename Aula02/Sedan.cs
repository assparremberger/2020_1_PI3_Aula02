using System;
namespace Aula02
{
	public class Sedan : Carro
	{
		public int capacidadeMalas;
		public Sedan()
		{

		}

	
		public void imprimir()
		{
			Console.WriteLine("Nome: {0} \nAno: {1} \nCapacidade: {2}",
				nome, ano, capacidadeMalas);
		}
		
	}
}
