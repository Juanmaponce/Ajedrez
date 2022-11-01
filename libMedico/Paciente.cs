using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libMedico
{
    public class Paciente : Persona
    {
        public Paciente(string name, string lastName, string obraSocial ) : base(name, lastName)
        {
            ObraSocial = obraSocial;
        }
        public string ObraSocial;

        public override string ToString()
        {
            return Name + " " + LastName + " " + ObraSocial;
        }
    }
}
