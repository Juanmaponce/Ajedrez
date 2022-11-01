using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    public abstract class Animal
    {
        public Animal(int edad, decimal peso, decimal altura)
        {
            Edad = edad;
            Peso = peso;
            Altura = altura;
        }

        public int Edad { get;  }
        public decimal Peso { get; }
        public decimal Altura { get; }

        public virtual string Imprimir()
        {
            return "Edad: " + Edad.ToString() + " Altura: " + Altura.ToString() + " Peso: "+ Peso.ToString();
        }

        public abstract string ImprimirComida();
    }
}
