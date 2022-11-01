using Animales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsAjedrez
{
    public partial class FormAnimales : Form
    {
        Leon leon = new Leon(10, 100, (decimal)1.20, "Marron");
        Loro loro = new Loro(3, 5, (decimal)0.3, "HOLA");
        Conejo conejo = new Conejo(2, 3, (decimal)0.5, (decimal)0.20);
        public FormAnimales()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(leon.Imprimir());
            MessageBox.Show(loro.Imprimir());
            MessageBox.Show(conejo.Imprimir());
        }

        private void btnComidas_Click(object sender, EventArgs e)
        {
            MessageBox.Show(leon.ImprimirComida());
            MessageBox.Show(loro.ImprimirComida());
            MessageBox.Show(conejo.ImprimirComida());
        }
    }
}
