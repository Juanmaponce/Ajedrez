using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    public class Empleado
    {

        public Empleado(int iD, string name, string lastname)
        {
            ID = iD;
            Name = name;
            Lastname = lastname;
            comision = 25;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }

        private static decimal comision;

        public static decimal Comision
        {
            get { return comision; }

            set { comision = value; }
            
        }

    }
}
