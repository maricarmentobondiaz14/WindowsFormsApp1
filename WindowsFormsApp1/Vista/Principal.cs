using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Principal : Form
    {
        AgregarExamen agr;
        ListadoExamen alistado;
        public Principal()
        {
            InitializeComponent();
            agr = new AgregarExamen();
            alistado = new ListadoExamen();
        }

        private void btnInsertarExamen_Click(object sender, EventArgs e)
        {
            agr.ShowDialog();
        }

        private void btnListExamen_Click(object sender, EventArgs e)
        {
            alistado.ShowDialog();

        }
    }
}
