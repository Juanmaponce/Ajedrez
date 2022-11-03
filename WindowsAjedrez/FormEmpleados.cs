using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Empleados;

namespace WindowsAjedrez
{
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void btnComision_Click(object sender, EventArgs e)
        {
            Empleado empleado1 = new Empleado(01, "Juan", "Perez");
            Empleado empleado2 = new Empleado(03, "Jose", "Sanchez");

            MessageBox.Show(Empleado.Comision.ToString());

            Empleado.Comision = 20;

            Empleado empleado3 = new Empleado(02, "Maria", "Diaz");
            Empleado empleado4= new Empleado(04, "Dana", "Rodriguez");

            MessageBox.Show(Empleado.Comision.ToString());

            //La comision es la misma para todos los empleados por que cada vez que se crea un un objeto se cambia el valor de la comision al que se le asigna en el constructor
        }
    }
}
