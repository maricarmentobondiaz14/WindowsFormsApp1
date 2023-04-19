using Apiexamen;
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
    public partial class AgregarExamen : Form
    {
        WsApiexamen wsApi = new WsApiexamen();

        public AgregarExamen()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int bandera = 1;
            if (rBWebService.Checked)
            {
                bandera = wsApi.AgregarExamen(
               txtBNombre.Text,
               txtBDescripcion.Text);

            }
            else if (rBDLL.Checked)
            {
                Apiexamen.ClsExamen cls = new ClsExamen();
                bandera = cls.AgregarExamen(
               txtBNombre.Text,
               txtBDescripcion.Text
                    );
            }

            if (bandera == 0)
            {
                MessageBox.Show("Se inserto correctamente el examen. ");

            }
            else
            {
                MessageBox.Show("Error verificar el código de error  " + bandera + ".");

            }
        }
    }
}
