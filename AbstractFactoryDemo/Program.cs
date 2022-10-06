using System;
using AbstractFactoryDemo.Domain.Enums;
using AbstractFactoryDemo.Domain.Products;
using AbstractFactoryDemo.Factory.AbstractFactory;

namespace AbstractFactory1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Criar as fábricas
            var boloFactory = MassasAbstractFactory.CriaFabricaMassas(TipoMassa.Bolo);
            var pizzaFactory = MassasAbstractFactory.CriaFabricaMassas(TipoMassa.Pizza);

            // Criar os objetos com base no tipo bolo
            var bolo1 = boloFactory.CriaMassa((TipoMassa)TipoBolo.Chocolate);
            var bolo2 = boloFactory.CriaMassa((TipoMassa)TipoBolo.Laranja);

            // Criar os objetos com base no tipo pizza
            var pizza1 = pizzaFactory.CriaMassa((TipoMassa)TipoPizza.Mussarela);
            var pizza2 = pizzaFactory.CriaMassa((TipoMassa)TipoPizza.Calabreza);

            // Exibe os detalhes
            ExibeDetalhes(bolo1);
            ExibeDetalhes(bolo2);
            ExibeDetalhes(pizza1);
            ExibeDetalhes(pizza2);

            Console.ReadLine();
        }

        private static void ExibeDetalhes(MassaBase massaBase)
        {
            Console.WriteLine($"Tipo : {massaBase.TipoMassa}");
            Console.WriteLine(massaBase.Nome);
            Console.WriteLine(massaBase.Ingredientes[0].ToString());
            Console.WriteLine("\n");
        }
    }
}
