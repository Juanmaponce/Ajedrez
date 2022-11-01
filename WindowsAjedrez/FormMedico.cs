using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using libMedico;

namespace WindowsAjedrez
{
    public partial class FormMedico : Form
    {
        public FormMedico()
        {
            InitializeComponent();
        }

        private void BtnMedicoPaciente_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico("Jose", "Perez", "Traumatologo");
            Paciente paciente = new Paciente("Juan", "Diaz", "OSDE");

            MessageBox.Show(medico.ToString());
            MessageBox.Show(paciente.ToString());
        }
    }
}
