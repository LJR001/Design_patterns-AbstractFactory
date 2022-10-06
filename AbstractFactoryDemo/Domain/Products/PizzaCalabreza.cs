using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryDemo.Domain.Enums;

namespace AbstractFactoryDemo.Domain.Products
{
    public sealed class PizzaCalabreza : Pizza
    {
        public PizzaCalabreza() : base("Pizza Calabreza", TipoMassa.Pizza)
        {
            Ingredientes.Add("Calabreza em cubos e tomates em cubos");
        }
    }
}
