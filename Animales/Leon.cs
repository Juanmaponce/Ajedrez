using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    public class Leon : Animal
    {
        public Leon(int edad, decimal peso, decimal altura, string colorMelena) : base(edad, peso, altura)
        {
            ColorMelena = colorMelena;
        }

        public string ColorMelena;

        public override string Imprimir()
        {
            return base.Imprimir() + "y el color de su melena es: " + ColorMelena;
        }

        public override string ImprimirComida()
        {
            return "El Leon come otros animales";
        }
    }
}
