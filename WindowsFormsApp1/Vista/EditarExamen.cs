using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Apiexamen;

namespace WindowsFormsApp1
{
    public partial class EditarExamen : Form
    {
        WsApiexamen wsApi = new WsApiexamen();
        public int identificador;

        public EditarExamen()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int bandera=1;
            if (rBWebService.Checked) {
                bandera = wsApi.ActualizarExamen(Convert.ToInt32(txtBIdExamen.Text),
               txtBNombre.Text,
               txtBDescripcion.Text);

            } else if (rBDLL.Checked) {
                Apiexamen.ClsExamen cls = new ClsExamen();
                bandera=cls.ActualizarExamen(Convert.ToInt32(txtBIdExamen.Text),
               txtBNombre.Text,
               txtBDescripcion.Text
                    );
            }
           
            if (bandera == 0)
            {
                MessageBox.Show("Se edito correctamente el examen. ");

            }
            else {
                MessageBox.Show("Error verificar el código de error  "+bandera+".");

            }
        }

        private void EditarExamen_Load(object sender, EventArgs e)
        {
            tblExamen tbl = new tblExamen();
            tbl = wsApi.ConsultarExamen(identificador);
            txtBIdExamen.Text = tbl.idExamen.ToString();
            txtBNombre.Text = tbl.nombre;
            txtBDescripcion.Text = tbl.descripcion;
            

        }
    }
}
