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
    public partial class ListadoExamen : Form
    {
        EditarExamen edit = new EditarExamen();
        WsApiexamen wsApi = new WsApiexamen();

        public ListadoExamen()
        {
            InitializeComponent();
        }

        private void ListadoExamen_Load(object sender, EventArgs e)
        {
            Apiexamen.ClsExamen cls = new ClsExamen();
            
            dtgvExamenes.DataSource = cls.ListarExamenes();

        }

        private void dtgvExamenes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvExamenes.SelectedRows.Count == 1)
            {
                
                Int32 idExamen = Convert.ToInt32(dtgvExamenes.CurrentRow.Cells[0].Value);
                
                int bandera = 1;
                if (e.ColumnIndex == 2)
                {
                    bandera=wsApi.EliminarExamen(idExamen);
                    if (bandera == 0)
                    {
                        MessageBox.Show("Se elimino correctamente el examen. ");

                    }
                    else
                    {
                        MessageBox.Show("Error verificar el código de error  " + bandera + ".");

                    }
                }
                if (e.ColumnIndex == 3)
                {
                    edit.identificador = idExamen;
                    edit.ShowDialog();

                }

            }

        }
    }
}
