using System;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VeiculoBuilder builder;
            var director = new Director();

            builder = new CarroBuilder();
            director.Contruct(builder);
            builder.Veiculo.Mostrar();

            builder = new MotoBuilder();
            director.Contruct(builder);
            builder.Veiculo.Mostrar();
            ////Cria Produto
            //var carro = new Veiculo("Carro Passeio");
            //carro["motor"] = "127c";
            //carro["pneus"] = "4";
            //carro["portas"] = "4";
            //carro.Mostrar();

            ////Cria Produto
            //var moto = new Veiculo("Motocicleta");
            //moto["motor"] = "50c";
            //moto["portas"] = "0";
            //moto["pneus"] = "2";
            //moto.Mostrar();
            Console.ReadLine();
        }
    }
}
