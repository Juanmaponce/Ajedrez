using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibAjedrez;
namespace WindowsAjedrez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPiezas_Click(object sender, EventArgs e)
        {
            Caballo caballo = new Caballo();
            Peon peon = new Peon();
            Torre torre = new Torre();

            MessageBox.Show(caballo.Mover());
            MessageBox.Show(torre.Mover());
            MessageBox.Show(peon.Mover());


        }
    }
}
