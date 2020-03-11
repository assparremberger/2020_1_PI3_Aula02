using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro car = new Carro();
            Console.WriteLine("Digite no nome do Carro: ");
            car.nome = Console.ReadLine();
            Console.WriteLine("Digite no ano do Carro: ");
            car.ano = int.Parse( Console.ReadLine() );

            //   Console.WriteLine("Nome: {0} \nAno: {1}",
            //       car.nome, car.ano);
            car.imprimir();

            Sedan car2 = new Sedan();
            car2.ano = 2020;
            car2.nome = "Cronos";
            car2.capacidadeMalas = 500;
            car2.imprimir();

        }
    }
}
