using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    public class Loro : Animal
    {
        public Loro(int edad, decimal peso, decimal altura, string palabraAprendida) : base(edad, peso, altura)
        {
            PalabraAprendida = palabraAprendida;
        }
        public string PalabraAprendida;

        public override string Imprimir()
        {
            return base.Imprimir() + " y aprendio a decir "+ PalabraAprendida;
        }

        public override string ImprimirComida()
        {
            return "El Loro come semillas";
        }
    }
}
