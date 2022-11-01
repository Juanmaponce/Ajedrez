using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    public class Conejo : Animal
    {
        public Conejo(int edad, decimal peso, decimal altura, decimal largoOrejas) : base(edad, peso, altura)
        {
            LargoOrejas = largoOrejas;
        }
        public decimal LargoOrejas;

        public override string Imprimir()
        {
            return base.Imprimir() + " y sus orejas miden" + LargoOrejas.ToString();
        }

        public override string ImprimirComida()
        {
            return "El conejo come zanahoria";
        }
    }
}
