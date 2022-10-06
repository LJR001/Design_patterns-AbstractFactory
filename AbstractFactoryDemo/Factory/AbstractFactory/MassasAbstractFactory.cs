using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryDemo.Domain.Enums;
using AbstractFactoryDemo.Domain.Products;

namespace AbstractFactoryDemo.Factory.AbstractFactory
{
    public abstract class MassasAbstractFactory
    {
        public abstract MassaBase CriaMassa(TipoMassa tipoMassa);
        public static MassasAbstractFactory CriaFabricaMassas(TipoMassa tipoMassa)
        {
            switch (tipoMassa)
            {
                case TipoMassa.Pizza:
                    {
                        return new PizzaFactory();
                    }
                case TipoMassa.Bolo:
                    {
                        return new BoloFactory();
                    }
                default:
                    throw new ArgumentOutOfRangeException(nameof(tipoMassa),
                        tipoMassa, null);
            }
        }
    }
}
