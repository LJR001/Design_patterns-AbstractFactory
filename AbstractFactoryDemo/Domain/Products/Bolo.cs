using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryDemo.Domain.Enums;

namespace AbstractFactoryDemo.Domain.Products
{
    public abstract class Bolo : MassaBase
    {
        public Bolo(string nome, TipoMassa tipo) : base(nome, tipo)
        {
        }
    }
}
