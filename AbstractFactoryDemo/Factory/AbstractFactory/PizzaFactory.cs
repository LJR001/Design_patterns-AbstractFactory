using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryDemo.Domain.Enums;
using AbstractFactoryDemo.Domain.Products;

namespace AbstractFactoryDemo.Factory.AbstractFactory
{
    public sealed class  PizzaFactory : MassasAbstractFactory
    {
        public override MassaBase CriaMassa(TipoMassa tipoMassa)
        {
            var tipoPizza = (TipoPizza)tipoMassa;

            switch (tipoPizza)
            {
                case TipoPizza.Mussarela:
                    {
                        return new PizzaMussarela();
                    }
                case TipoPizza.Calabreza:
                    {
                        return new PizzaCalabreza();
                    }
                default:
                    throw new ArgumentOutOfRangeException("Tipo não implementado");
            }
        }
    }
}
