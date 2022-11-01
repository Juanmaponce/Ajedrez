using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libMedico
{
    public class Medico : Persona
    {
        public Medico(string name, string lastName, string especialidad) : base(name, lastName)
        {
            this.Especialidad = especialidad;
        }
        public string Especialidad;

        public override string ToString()
        {
            return Name +" "+ LastName +" "+ Especialidad;
        }
    }
}
